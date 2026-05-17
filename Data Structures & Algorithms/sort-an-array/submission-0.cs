public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void MergeSort(int[] arr, int l, int r) {
        if (l == r) return;

        int m = (l + r) / 2;
        MergeSort(arr, l, m);
        MergeSort(arr, m + 1, r);
        Merge(arr, l, m, r);
    }

    private void Merge(int[] arr, int L, int M, int R) {
        int[] left = arr[L..(M + 1)];
        int[] right = arr[(M + 1)..(R + 1)];

        int i = L, j = 0, k = 0;

        while (j < left.Length && k < right.Length) {
            if (left[j] <= right[k]) {
                arr[i++] = left[j++];
            } else {
                arr[i++] = right[k++];
            }
        }

        while (j < left.Length) {
            arr[i++] = left[j++];
        }

        while (k < right.Length) {
            arr[i++] = right[k++];
        }
    }
}