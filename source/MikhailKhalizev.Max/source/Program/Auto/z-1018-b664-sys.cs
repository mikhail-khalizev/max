using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_b664-254a8bd0")]
        public void /* sys */ Method_1018_b664()
        {
            ii(0x1018_b664, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_b665, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_b666, 1);  push(edx);                            /* push edx */
            ii(0x1018_b667, 1);  push(esi);                            /* push esi */
            ii(0x1018_b668, 1);  push(edi);                            /* push edi */
            ii(0x1018_b669, 1);  push(ebp);                            /* push ebp */
            ii(0x1018_b66a, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1018_b66c, 6);  cmp(memd[ds, eax], 0xfeba_feba);      /* cmp dword [eax], 0xfebafeba */
            ii(0x1018_b672, 2);  if(jnz(0x1018_b6d2, 0x5e)) goto l_0x1018_b6d2;/* jnz 0x1018b6d2 */
            ii(0x1018_b674, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x1018_b677, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1018_b679, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1018_b67b, 2);  if(jle(0x1018_b6b1, 0x34)) goto l_0x1018_b6b1;/* jle 0x1018b6b1 */
            ii(0x1018_b67d, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
        l_0x1018_b67f:
            ii(0x1018_b67f, 3);  mov(eax, memd[ds, ecx + 32]);         /* mov eax, [ecx+0x20] */
            ii(0x1018_b682, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1018_b684, 2);  mov(ebp, memd[ds, eax]);              /* mov ebp, [eax] */
            ii(0x1018_b686, 2);  test(ebp, ebp);                       /* test ebp, ebp */
            ii(0x1018_b688, 2);  if(jz(0x1018_b692, 8)) goto l_0x1018_b692;/* jz 0x1018b692 */
            ii(0x1018_b68a, 2);  mov(eax, ebp);                        /* mov eax, ebp */
            ii(0x1018_b68c, 6);  call_abs(memd[ds, 0x101b_e8b8]);      /* call dword [0x101be8b8] */ /* Вызов '0x1018_b5c0'. */
        l_0x1018_b692:
            ii(0x1018_b692, 3);  mov(eax, memd[ds, ecx + 32]);         /* mov eax, [ecx+0x20] */
            ii(0x1018_b695, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1018_b697, 3);  mov(esi, memd[ds, eax + 4]);          /* mov esi, [eax+0x4] */
            ii(0x1018_b69a, 2);  test(esi, esi);                       /* test esi, esi */
            ii(0x1018_b69c, 2);  if(jz(0x1018_b6a6, 8)) goto l_0x1018_b6a6;/* jz 0x1018b6a6 */
            ii(0x1018_b69e, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1018_b6a0, 6);  call_abs(memd[ds, 0x101b_e8b8]);      /* call dword [0x101be8b8] */ /* Вызов '0x1018_b5c0'. */
        l_0x1018_b6a6:
            ii(0x1018_b6a6, 1);  inc(edx);                             /* inc edx */
            ii(0x1018_b6a7, 3);  mov(esi, memd[ds, ecx + 4]);          /* mov esi, [ecx+0x4] */
            ii(0x1018_b6aa, 3);  add(ebx, 8);                          /* add ebx, 0x8 */
            ii(0x1018_b6ad, 2);  cmp(edx, esi);                        /* cmp edx, esi */
            ii(0x1018_b6af, 2);  if(jl(0x1018_b67f, -0x32)) goto l_0x1018_b67f;/* jl 0x1018b67f */
        l_0x1018_b6b1:
            ii(0x1018_b6b1, 3);  mov(edi, memd[ds, ecx + 32]);         /* mov edi, [ecx+0x20] */
            ii(0x1018_b6b4, 2);  test(edi, edi);                       /* test edi, edi */
            ii(0x1018_b6b6, 2);  if(jz(0x1018_b6c0, 8)) goto l_0x1018_b6c0;/* jz 0x1018b6c0 */
            ii(0x1018_b6b8, 2);  mov(eax, edi);                        /* mov eax, edi */
            ii(0x1018_b6ba, 6);  call_abs(memd[ds, 0x101b_e8b8]);      /* call dword [0x101be8b8] */ /* Вызов '0x1018_b5c0'. */
        l_0x1018_b6c0:
            ii(0x1018_b6c0, 5);  mov(ebx, 0x24);                       /* mov ebx, 0x24 */
            ii(0x1018_b6c5, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1018_b6c7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1018_b6c9, 5);  call(Definitions.sys_memset, -0x2_58ee);/* call 0x10165de0 */
            ii(0x1018_b6ce, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1018_b6d0, 2);  jmp(0x1018_b6d7, 5); goto l_0x1018_b6d7;/* jmp 0x1018b6d7 */
        l_0x1018_b6d2:
            ii(0x1018_b6d2, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
        l_0x1018_b6d7:
            ii(0x1018_b6d7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1018_b6d8, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_b6d9, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_b6da, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_b6db, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_b6dc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_b6dd, 1);  ret();                                /* ret */
        }
    }
}
