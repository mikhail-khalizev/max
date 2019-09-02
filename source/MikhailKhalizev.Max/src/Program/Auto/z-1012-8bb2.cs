using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_8bb2-85d5359")]
        public void Method_1012_8bb2()
        {
            ii(0x1012_8bb2, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_8bb7, 5); call(Definitions.sys_check_available_stack_size, 0x3_d196); /* call 0x10165d52 */
            ii(0x1012_8bbc, 1); push(ebx);                              /* push ebx */
            ii(0x1012_8bbd, 1); push(ecx);                              /* push ecx */
            ii(0x1012_8bbe, 1); push(edx);                              /* push edx */
            ii(0x1012_8bbf, 1); push(esi);                              /* push esi */
            ii(0x1012_8bc0, 1); push(edi);                              /* push edi */
            ii(0x1012_8bc1, 1); push(ebp);                              /* push ebp */
            ii(0x1012_8bc2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_8bc4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_8bca, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_8bcd, 7); mov(memd[ss, ebp - 12], 0x101c_5c21);   /* mov dword [ebp-0xc], 0x101c5c21 */
            ii(0x1012_8bd4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_8bd7, 5); call(0x1007_623c, -0xb_29a0);           /* call 0x1007623c */
            ii(0x1012_8bdc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_8bde, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8be1, 5); call(0x1007_6800, -0xb_23e6);           /* call 0x10076800 */
            ii(0x1012_8be6, 7); mov(memb[ds, 0x101c_5c1c], 0x14);       /* mov byte [0x101c5c1c], 0x14 */
            ii(0x1012_8bed, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_8bf0, 5); call(0x1007_6154, -0xb_2aa1);           /* call 0x10076154 */
            ii(0x1012_8bf5, 6); mov(memw[ds, 0x101c_5c1d], ax);         /* mov [0x101c5c1d], ax */
            ii(0x1012_8bfb, 9); mov(memw[ds, 0x101c_5c1f], 0x1c);       /* mov word [0x101c5c1f], 0x1c */
            ii(0x1012_8c04, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8c07, 5); call(0x1007_6730, -0xb_24dc);           /* call 0x10076730 */
            ii(0x1012_8c0c, 4); mov(dx, memw[ds, eax + 8]);             /* mov dx, [eax+0x8] */
            ii(0x1012_8c10, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8c13, 4); mov(memw[ds, eax + 2], dx);             /* mov [eax+0x2], dx */
            ii(0x1012_8c17, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8c1a, 5); call(0x1007_6730, -0xb_24ef);           /* call 0x10076730 */
            ii(0x1012_8c1f, 4); mov(dx, memw[ds, eax + 10]);            /* mov dx, [eax+0xa] */
            ii(0x1012_8c23, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8c26, 4); mov(memw[ds, eax + 4], dx);             /* mov [eax+0x4], dx */
            ii(0x1012_8c2a, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8c2d, 5); call(0x1007_6730, -0xb_2502);           /* call 0x10076730 */
            ii(0x1012_8c32, 4); mov(dx, memw[ds, eax + 12]);            /* mov dx, [eax+0xc] */
            ii(0x1012_8c36, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8c39, 4); mov(memw[ds, eax + 6], dx);             /* mov [eax+0x6], dx */
            ii(0x1012_8c3d, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8c40, 5); call(0x1007_6730, -0xb_2515);           /* call 0x10076730 */
            ii(0x1012_8c45, 4); mov(dx, memw[ds, eax + 14]);            /* mov dx, [eax+0xe] */
            ii(0x1012_8c49, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8c4c, 4); mov(memw[ds, eax + 8], dx);             /* mov [eax+0x8], dx */
            ii(0x1012_8c50, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8c53, 5); call(0x1007_6730, -0xb_2528);           /* call 0x10076730 */
            ii(0x1012_8c58, 4); mov(dx, memw[ds, eax + 16]);            /* mov dx, [eax+0x10] */
            ii(0x1012_8c5c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8c5f, 4); mov(memw[ds, eax + 10], dx);            /* mov [eax+0xa], dx */
            ii(0x1012_8c63, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8c66, 5); call(0x1007_6730, -0xb_253b);           /* call 0x10076730 */
            ii(0x1012_8c6b, 4); mov(dx, memw[ds, eax + 18]);            /* mov dx, [eax+0x12] */
            ii(0x1012_8c6f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8c72, 4); mov(memw[ds, eax + 12], dx);            /* mov [eax+0xc], dx */
            ii(0x1012_8c76, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8c79, 5); call(0x1007_6730, -0xb_254e);           /* call 0x10076730 */
            ii(0x1012_8c7e, 4); mov(dx, memw[ds, eax + 20]);            /* mov dx, [eax+0x14] */
            ii(0x1012_8c82, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8c85, 4); mov(memw[ds, eax + 14], dx);            /* mov [eax+0xe], dx */
            ii(0x1012_8c89, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8c8c, 5); call(0x1007_6730, -0xb_2561);           /* call 0x10076730 */
            ii(0x1012_8c91, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_8c93, 3); mov(dl, memb[ds, eax + 22]);            /* mov dl, [eax+0x16] */
            ii(0x1012_8c96, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8c99, 4); mov(memw[ds, eax + 16], dx);            /* mov [eax+0x10], dx */
            ii(0x1012_8c9d, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8ca0, 5); call(0x1007_6730, -0xb_2575);           /* call 0x10076730 */
            ii(0x1012_8ca5, 4); mov(dx, memw[ds, eax + 23]);            /* mov dx, [eax+0x17] */
            ii(0x1012_8ca9, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8cac, 4); mov(memw[ds, eax + 18], dx);            /* mov [eax+0x12], dx */
            ii(0x1012_8cb0, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8cb3, 5); call(0x1007_6730, -0xb_2588);           /* call 0x10076730 */
            ii(0x1012_8cb8, 4); mov(dx, memw[ds, eax + 25]);            /* mov dx, [eax+0x19] */
            ii(0x1012_8cbc, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8cbf, 4); mov(memw[ds, eax + 20], dx);            /* mov [eax+0x14], dx */
            ii(0x1012_8cc3, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8cc6, 5); call(0x1007_6730, -0xb_259b);           /* call 0x10076730 */
            ii(0x1012_8ccb, 4); mov(dx, memw[ds, eax + 27]);            /* mov dx, [eax+0x1b] */
            ii(0x1012_8ccf, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8cd2, 4); mov(memw[ds, eax + 22], dx);            /* mov [eax+0x16], dx */
            ii(0x1012_8cd6, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8cd9, 5); call(0x1007_6730, -0xb_25ae);           /* call 0x10076730 */
            ii(0x1012_8cde, 4); mov(dx, memw[ds, eax + 29]);            /* mov dx, [eax+0x1d] */
            ii(0x1012_8ce2, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8ce5, 4); mov(memw[ds, eax + 24], dx);            /* mov [eax+0x18], dx */
            ii(0x1012_8ce9, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8cec, 5); call(0x1007_6730, -0xb_25c1);           /* call 0x10076730 */
            ii(0x1012_8cf1, 4); mov(dx, memw[ds, eax + 31]);            /* mov dx, [eax+0x1f] */
            ii(0x1012_8cf5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_8cf8, 4); mov(memw[ds, eax + 26], dx);            /* mov [eax+0x1a], dx */
            ii(0x1012_8cfc, 5); mov(eax, 4);                            /* mov eax, 0x4 */
            ii(0x1012_8d01, 5); call(0x1012_5be9, -0x311d);             /* call 0x10125be9 */
            ii(0x1012_8d06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_8d08, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_8d0b, 5); call(0x1007_5eec, -0xb_2e24);           /* call 0x10075eec */
            ii(0x1012_8d10, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_8d12, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_8d13, 1); pop(edi);                               /* pop edi */
            ii(0x1012_8d14, 1); pop(esi);                               /* pop esi */
            ii(0x1012_8d15, 1); pop(edx);                               /* pop edx */
            ii(0x1012_8d16, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_8d17, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_8d18, 1); ret();                                  /* ret */
        }
    }
}
