using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_6e2e-ca63372")]
        public void Method_100e_6e2e()
        {
            ii(0x100e_6e2e, 5);  push(0x64);                           /* push 0x64 */
            ii(0x100e_6e33, 5);  call(Definitions.sys_check_available_stack_size, 0x7_ef1a);/* call 0x10165d52 */
            ii(0x100e_6e38, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_6e39, 1);  push(esi);                            /* push esi */
            ii(0x100e_6e3a, 1);  push(edi);                            /* push edi */
            ii(0x100e_6e3b, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_6e3c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_6e3e, 6);  sub(esp, 0x44);                       /* sub esp, 0x44 */
            ii(0x100e_6e44, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_6e47, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_6e4a, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100e_6e4d, 5);  mov(eax, 0x26);                       /* mov eax, 0x26 */
            ii(0x100e_6e52, 5);  call(0x100e_883d, 0x19e6);            /* call 0x100e883d */
            ii(0x100e_6e57, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100e_6e5a, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_6e5d, 7);  mov(memd[ss, ebp - 28], 0x280);       /* mov dword [ebp-0x1c], 0x280 */
            ii(0x100e_6e64, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_6e67, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x100e_6e6b, 2);  if(jz(0x100e_6e76, 9)) goto l_0x100e_6e76;/* jz 0x100e6e76 */
            ii(0x100e_6e6d, 7);  mov(memd[ss, ebp - 16], 0x80);        /* mov dword [ebp-0x10], 0x80 */
            ii(0x100e_6e74, 2);  jmp(0x100e_6e7d, 7); goto l_0x100e_6e7d;/* jmp 0x100e6e7d */
        l_0x100e_6e76:
            ii(0x100e_6e76, 7);  mov(memd[ss, ebp - 16], 0x40);        /* mov dword [ebp-0x10], 0x40 */
        l_0x100e_6e7d:
            ii(0x100e_6e7d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_6e80, 3);  mov(ebx, memd[ds, eax + 20]);         /* mov ebx, [eax+0x14] */
            ii(0x100e_6e83, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100e_6e86, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_6e8a, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_6e8c, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_6e8f, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_6e91, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100e_6e93, 2);  sub(ebx, eax);                        /* sub ebx, eax */
            ii(0x100e_6e95, 3);  mov(memd[ss, ebp - 24], ebx);         /* mov [ebp-0x18], ebx */
            ii(0x100e_6e98, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_6e9b, 3);  mov(ebx, memd[ds, eax + 22]);         /* mov ebx, [eax+0x16] */
            ii(0x100e_6e9e, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100e_6ea1, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_6ea5, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_6ea7, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_6eaa, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_6eac, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100e_6eae, 2);  sub(ebx, eax);                        /* sub ebx, eax */
            ii(0x100e_6eb0, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100e_6eb2, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_6eb5, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_6eb9, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x100e_6ebc, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_6ebe, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_6ec1, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x100e_6ec7, 6);  mov(edx, memd[ds, 0x101c_38fa]);      /* mov edx, [0x101c38fa] */
            ii(0x100e_6ecd, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100e_6ed0, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_6ed2, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x100e_6ed5, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x100e_6ed8, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100e_6edc, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x100e_6edf, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_6ee1, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_6ee4, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x100e_6eea, 6);  mov(edx, memd[ds, 0x101c_38fc]);      /* mov edx, [0x101c38fc] */
            ii(0x100e_6ef0, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100e_6ef3, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_6ef5, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x100e_6ef8, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100e_6efb, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_6eff, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x100e_6f02, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_6f04, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_6f07, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x100e_6f0d, 3);  add(eax, memd[ss, ebp - 52]);         /* add eax, [ebp-0x34] */
            ii(0x100e_6f10, 3);  sub(eax, 8);                          /* sub eax, 0x8 */
            ii(0x100e_6f13, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100e_6f16, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_6f1a, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x100e_6f1d, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_6f1f, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_6f22, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x100e_6f28, 3);  add(eax, memd[ss, ebp - 48]);         /* add eax, [ebp-0x30] */
            ii(0x100e_6f2b, 3);  sub(eax, 8);                          /* sub eax, 0x8 */
            ii(0x100e_6f2e, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100e_6f31, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100e_6f34, 3);  cmp(eax, memd[ss, ebp - 44]);         /* cmp eax, [ebp-0x2c] */
            ii(0x100e_6f37, 2);  if(jge(0x100e_6f41, 8)) goto l_0x100e_6f41;/* jge 0x100e6f41 */
            ii(0x100e_6f39, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100e_6f3c, 3);  cmp(eax, memd[ss, ebp - 40]);         /* cmp eax, [ebp-0x28] */
            ii(0x100e_6f3f, 2);  if(jl(0x100e_6f46, 5)) goto l_0x100e_6f46;/* jl 0x100e6f46 */
        l_0x100e_6f41:
            ii(0x100e_6f41, 5);  jmp(0x100e_6ffd, 0xb7); goto l_0x100e_6ffd;/* jmp 0x100e6ffd */
        l_0x100e_6f46:
            ii(0x100e_6f46, 5);  mov(eax, memd[ds, 0x101c_38c0]);      /* mov eax, [0x101c38c0] */
            ii(0x100e_6f4b, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100e_6f4e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_6f51, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x100e_6f55, 2);  if(jnz(0x100e_6f67, 0x10)) goto l_0x100e_6f67;/* jnz 0x100e6f67 */
            ii(0x100e_6f57, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100e_6f5a, 3);  mov(edx, memd[ss, ebp - 36]);         /* mov edx, [ebp-0x24] */
            ii(0x100e_6f5d, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_6f60, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_6f62, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100e_6f64, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
        l_0x100e_6f67:
            ii(0x100e_6f67, 7);  mov(memd[ss, ebp - 68], 0);           /* mov dword [ebp-0x44], 0x0 */
            ii(0x100e_6f6e, 7);  mov(memd[ss, ebp - 64], 0);           /* mov dword [ebp-0x40], 0x0 */
            ii(0x100e_6f75, 6);  mov(edx, memd[ds, 0x101c_38f4]);      /* mov edx, [0x101c38f4] */
            ii(0x100e_6f7b, 6);  sub(edx, memd[ds, 0x101c_38ec]);      /* sub edx, [0x101c38ec] */
            ii(0x100e_6f81, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x100e_6f84, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_6f86, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_6f89, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x100e_6f8f, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100e_6f92, 6);  mov(edx, memd[ds, 0x101c_38f8]);      /* mov edx, [0x101c38f8] */
            ii(0x100e_6f98, 6);  sub(edx, memd[ds, 0x101c_38f0]);      /* sub edx, [0x101c38f0] */
            ii(0x100e_6f9e, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x100e_6fa1, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_6fa3, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_6fa6, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x100e_6fac, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x100e_6faf, 4);  cmp(memd[ss, ebp - 36], 0x2a);        /* cmp dword [ebp-0x24], 0x2a */
            ii(0x100e_6fb3, 2);  if(jl(0x100e_6fc1, 0xc)) goto l_0x100e_6fc1;/* jl 0x100e6fc1 */
            ii(0x100e_6fb5, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100e_6fba, 5);  call(/* sys */ 0x1016_a24c, 0x8_328d);/* call 0x1016a24c */
            ii(0x100e_6fbf, 2);  jmp(0x100e_6fdd, 0x1c); goto l_0x100e_6fdd;/* jmp 0x100e6fdd */
        l_0x100e_6fc1:
            ii(0x100e_6fc1, 4);  cmp(memd[ss, ebp - 36], 0x18);        /* cmp dword [ebp-0x24], 0x18 */
            ii(0x100e_6fc5, 2);  if(jl(0x100e_6fd3, 0xc)) goto l_0x100e_6fd3;/* jl 0x100e6fd3 */
            ii(0x100e_6fc7, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x100e_6fcc, 5);  call(/* sys */ 0x1016_a24c, 0x8_327b);/* call 0x1016a24c */
            ii(0x100e_6fd1, 2);  jmp(0x100e_6fdd, 0xa); goto l_0x100e_6fdd;/* jmp 0x100e6fdd */
        l_0x100e_6fd3:
            ii(0x100e_6fd3, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x100e_6fd8, 5);  call(/* sys */ 0x1016_a24c, 0x8_326f);/* call 0x1016a24c */
        l_0x100e_6fdd:
            ii(0x100e_6fdd, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100e_6fe2, 1);  push(eax);                            /* push eax */
            ii(0x100e_6fe3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_6fe6, 1);  push(eax);                            /* push eax */
            ii(0x100e_6fe7, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x100e_6fea, 1);  push(eax);                            /* push eax */
            ii(0x100e_6feb, 3);  lea(ecx, memd[ss, ebp - 52]);         /* lea ecx, [ebp-0x34] */
            ii(0x100e_6fee, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100e_6ff1, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100e_6ff5, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_6ff8, 5);  call(0x100e_9dcc, 0x2dcf);            /* call 0x100e9dcc */
        l_0x100e_6ffd:
            ii(0x100e_6ffd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_6fff, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_7000, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_7001, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_7002, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_7003, 1);  ret();                                /* ret */
        }
    }
}
