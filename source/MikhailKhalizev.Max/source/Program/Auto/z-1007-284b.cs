using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_284b-e7414d86")]
        public void Method_1007_284b()
        {
            ii(0x1007_284b, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_2850, 5);  call(Definitions.sys_check_available_stack_size, 0xf_34fd);/* call 0x10165d52 */
            ii(0x1007_2855, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_2856, 1);  push(esi);                            /* push esi */
            ii(0x1007_2857, 1);  push(edi);                            /* push edi */
            ii(0x1007_2858, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_2859, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_285b, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1007_2861, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_2864, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_2867, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1007_286a, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_286d, 5);  mov(eax, 0x101c_39b8);                /* mov eax, 0x101c39b8 */
            ii(0x1007_2872, 5);  call(0x1010_3752, 0x9_0edb);          /* call 0x10103752 */
            ii(0x1007_2877, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1007_287c, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_287f, 5);  mov(eax, 0x101c_39b8);                /* mov eax, 0x101c39b8 */
            ii(0x1007_2884, 5);  call(0x1010_346f, 0x9_0be6);          /* call 0x1010346f */
            ii(0x1007_2889, 5);  mov(ebx, 0x40_0000);                  /* mov ebx, 0x400000 */
            ii(0x1007_288e, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1007_2892, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_2896, 5);  call(0x1007_36d8, 0xe3d);             /* call 0x100736d8 */
            ii(0x1007_289b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_289e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_28a1, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_28a5, 2);  if(jz(0x1007_28b0, 9)) goto l_0x1007_28b0;/* jz 0x100728b0 */
            ii(0x1007_28a7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_28aa, 4);  test(memb[ds, eax + 18], 1);          /* test byte [eax+0x12], 0x1 */
            ii(0x1007_28ae, 2);  if(jz(0x1007_28b6, 6)) goto l_0x1007_28b6;/* jz 0x100728b6 */
        l_0x1007_28b0:
            ii(0x1007_28b0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_28b3, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x1007_28b6:
            ii(0x1007_28b6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_28b9, 3);  cmp(eax, memd[ss, ebp - 12]);         /* cmp eax, [ebp-0xc] */
            ii(0x1007_28bc, 2);  if(jnz(0x1007_28da, 0x1c)) goto l_0x1007_28da;/* jnz 0x100728da */
            ii(0x1007_28be, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_28c1, 5);  mov(eax, 0x101c_39b8);                /* mov eax, 0x101c39b8 */
            ii(0x1007_28c6, 5);  call(0x1010_3752, 0x9_0e87);          /* call 0x10103752 */
            ii(0x1007_28cb, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_28cd, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_28d0, 5);  mov(eax, 0x101c_39b8);                /* mov eax, 0x101c39b8 */
            ii(0x1007_28d5, 5);  call(0x1010_346f, 0x9_0b95);          /* call 0x1010346f */
        l_0x1007_28da:
            ii(0x1007_28da, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_28dd, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_28e0, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_28e3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_28e5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_28e6, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_28e7, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_28e8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_28e9, 1);  ret();                                /* ret */
        }
    }
}
