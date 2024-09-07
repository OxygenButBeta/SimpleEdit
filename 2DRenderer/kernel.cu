
#include "cuda_runtime.h"
#include "device_launch_parameters.h"

#include <stdio.h>

__global__ void grayscaleKernel(unsigned char* rgbData, unsigned char* grayData, int width, int height) {
    int x = blockIdx.x * blockDim.x + threadIdx.x;
    int y = blockIdx.y * blockDim.y + threadIdx.y;
    if (x < width && y < height) {
        int idx = (y * width + x) * 3;  // RGB için 3 kanal
        unsigned char r = rgbData[idx];
        unsigned char g = rgbData[idx + 1];
        unsigned char b = rgbData[idx + 2];

        // Gri tonlama formülü: (R + G + B) / 3
        grayData[y * width + x] = (r + g + b) / 3;
    }
}

extern "C" void runGrayscale(unsigned char* rgbData, unsigned char* grayData, int width, int height) {
    unsigned char* d_rgbData;
    unsigned char* d_grayData;

    size_t rgbSize = width * height * 3 * sizeof(unsigned char);
    size_t graySize = width * height * sizeof(unsigned char);

    // GPU'ya bellek tahsisi
    cudaMalloc(&d_rgbData, rgbSize);
    cudaMalloc(&d_grayData, graySize);

    // CPU'dan GPU'ya veri kopyalama
    cudaMemcpy(d_rgbData, rgbData, rgbSize, cudaMemcpyHostToDevice);

    // Kernel'i çalıştırma (16x16 blok boyutu kullandık)
    dim3 blockDim(16, 16);
    dim3 gridDim((width + blockDim.x - 1) / blockDim.x, (height + blockDim.y - 1) / blockDim.y);
    grayscaleKernel <<<gridDim, blockDim >> > (d_rgbData, d_grayData, width, height);

    // Sonuçları GPU'dan CPU'ya geri kopyalama
    cudaMemcpy(grayData, d_grayData, graySize, cudaMemcpyDeviceToHost);

    // Belleği serbest bırakma
    cudaFree(d_rgbData);
    cudaFree(d_grayData);
}
int main()
{
	return 0;
}