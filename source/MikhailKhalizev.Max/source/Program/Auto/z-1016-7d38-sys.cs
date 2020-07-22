using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7d38-7f82eb11")]
        public void /* sys */ Method_1016_7d38()
        {
            ii(0x1016_7d38, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_7d39, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_7d3a, 1);  push(esi);                            /* push esi */
            ii(0x1016_7d3b, 1);  push(edi);                            /* push edi */
            ii(0x1016_7d3c, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_7d3d, 2);  mov(edi, eax);                        /* mov edi, eax */
            ii(0x1016_7d3f, 2);  mov(ebp, edx);                        /* mov ebp, edx */
            ii(0x1016_7d41, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1016_7d46, 6);  mov(ebx, memd[ds, 0x101c_b2d8]);      /* mov ebx, [0x101cb2d8] */
            ii(0x1016_7d4c, 2);  xor(esi, esi);                        /* xor esi, esi */
            ii(0x1016_7d4e, 6);  mov(memd[ds, 0x101c_b2d0], edx);      /* mov [0x101cb2d0], edx */
            ii(0x1016_7d54, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1016_7d56, 2);  if(jle(0x1016_7d76, 0x1e)) goto l_0x1016_7d76;/* jle 0x10167d76 */
            ii(0x1016_7d58, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
        l_0x1016_7d5a:
            ii(0x1016_7d5a, 2);  mov(ebx, ebp);                        /* mov ebx, ebp */
            ii(0x1016_7d5c, 2);  mov(edx, edi);                        /* mov edx, edi */
            ii(0x1016_7d5e, 6);  mov(eax, memd[ds, ecx + 0x101c_b1fc]);/* mov eax, [ecx+0x101cb1fc] */
            ii(0x1016_7d64, 5);  call(/* sys */ 0x1016_7500, -0x869);  /* call 0x10167500 */
            ii(0x1016_7d69, 1);  inc(esi);                             /* inc esi */
            ii(0x1016_7d6a, 5);  mov(eax, memd[ds, 0x101c_b2d8]);      /* mov eax, [0x101cb2d8] */
            ii(0x1016_7d6f, 3);  add(ecx, 4);                          /* add ecx, 0x4 */
            ii(0x1016_7d72, 2);  cmp(esi, eax);                        /* cmp esi, eax */
            ii(0x1016_7d74, 2);  if(jl(0x1016_7d5a, -0x1c)) goto l_0x1016_7d5a;/* jl 0x10167d5a */
        l_0x1016_7d76:
            ii(0x1016_7d76, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_7d78, 6);  mov(memd[ds, 0x101c_b2d0], edx);      /* mov [0x101cb2d0], edx */
            ii(0x1016_7d7e, 2);  test(ebp, ebp);                       /* test ebp, ebp */
            ii(0x1016_7d80, 2);  if(jnz(0x1016_7da4, 0x22)) goto l_0x1016_7da4;/* jnz 0x10167da4 */
            ii(0x1016_7d82, 5);  call(/* sys */ 0x1016_c350, 0x45c9);  /* call 0x1016c350 */
            ii(0x1016_7d87, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_7d89, 2);  if(jnz(0x1016_7da4, 0x19)) goto l_0x1016_7da4;/* jnz 0x10167da4 */
            ii(0x1016_7d8b, 3);  mov(ecx, memd[ds, edi + 12]);         /* mov ecx, [edi+0xc] */
            ii(0x1016_7d8e, 3);  mov(ebx, memd[ds, edi + 8]);          /* mov ebx, [edi+0x8] */
            ii(0x1016_7d91, 3);  mov(edx, memd[ds, edi + 4]);          /* mov edx, [edi+0x4] */
            ii(0x1016_7d94, 2);  mov(eax, memd[ds, edi]);              /* mov eax, [edi] */
            ii(0x1016_7d96, 5);  call(/* sys */ 0x1016_c184, 0x43e9);  /* call 0x1016c184 */
            ii(0x1016_7d9b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_7d9d, 2);  if(jz(0x1016_7da4, 5)) goto l_0x1016_7da4;/* jz 0x10167da4 */
            ii(0x1016_7d9f, 5);  call(/* sys */ 0x1016_bcc4, 0x3f20);  /* call 0x1016bcc4 */
        l_0x1016_7da4:
            ii(0x1016_7da4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_7da5, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_7da6, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_7da7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_7da8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_7da9, 1);  ret();                                /* ret */
        }
    }
}
