using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MergeSort:sorting
    {
        public void sort(int[] vet, int left, int right)
        {
            int middle;
            if (right > left)
            {
                middle = (right + left) / 2;
                sort(vet, left, middle);
                sort(vet, middle + 1, right);

                merge(vet, left, middle + 1, right);
            }
        }
        public void merge(int[] vet, int left, int middle, int right)
        {
            int i;
            int[] v2 = new int[10000];
            int leftend = middle - 1;
            int leftstart = left;
            int rightstart = right - left + 1;

            while (left <= leftend && middle <= right)
            {
                if (vet[left] <= vet[middle])
                {
                    v2[leftstart++] = vet[left++];

                }
                else
                {
                    v2[leftstart++] = vet[middle++];
                }
            }

            while (left <= leftend)
            {
                v2[leftstart++] = vet[left++];
            }
            while (middle <= right)
            {
                v2[leftstart++] = vet[middle++];
            }

            for (i = 0; i < rightstart; i++)
            {
                vet[right] = v2[right];
                right--;
            }
        }
    }
}
