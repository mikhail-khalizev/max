using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_6d5a-7c41b982")]
        public void Method_1012_6d5a()
        {
            ii(0x1012_6d5a, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1012_6d5f, 5);  call(Definitions.sys_check_available_stack_size, 0x3_efee);/* call 0x10165d52 */
            ii(0x1012_6d64, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_6d65, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_6d66, 1);  push(edx);                            /* push edx */
            ii(0x1012_6d67, 1);  push(esi);                            /* push esi */
            ii(0x1012_6d68, 1);  push(edi);                            /* push edi */
            ii(0x1012_6d69, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_6d6a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_6d6c, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1012_6d72, 5);  mov(eax, 0x46);                       /* mov eax, 0x46 */
            ii(0x1012_6d77, 5);  call(0x1007_5fdc, -0xb_0da0);         /* call 0x10075fdc */
            ii(0x1012_6d7c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_6d7f, 5);  mov(eax, 0x47);                       /* mov eax, 0x47 */
            ii(0x1012_6d84, 5);  call(0x1007_5fdc, -0xb_0dad);         /* call 0x10075fdc */
            ii(0x1012_6d89, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_6d8c, 7);  mov(memd[ss, ebp - 12], 0x101c_59f5); /* mov dword [ebp-0xc], 0x101c59f5 */
            ii(0x1012_6d93, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_6d96, 3);  mov(al, memb[ds, eax + 4]);           /* mov al, [eax+0x4] */
            ii(0x1012_6d99, 5);  mov(memb[ds, 0x101c_37c9], al);       /* mov [0x101c37c9], al */
            ii(0x1012_6d9e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_6da0, 6);  mov(dl, memb[ds, 0x101c_37c9]);       /* mov dl, [0x101c37c9] */
            ii(0x1012_6da6, 5);  mov(eax, 0x49);                       /* mov eax, 0x49 */
            ii(0x1012_6dab, 5);  call(0x100c_aafc, -0x5_c2b4);         /* call 0x100caafc */
            ii(0x1012_6db0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_6db3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_6db5, 3);  mov(dl, memb[ds, eax + 5]);           /* mov dl, [eax+0x5] */
            ii(0x1012_6db8, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x1012_6dbd, 5);  call(0x100c_aafc, -0x5_c2c6);         /* call 0x100caafc */
            ii(0x1012_6dc2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_6dc5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_6dc7, 3);  mov(dl, memb[ds, eax + 6]);           /* mov dl, [eax+0x6] */
            ii(0x1012_6dca, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x1012_6dcf, 5);  call(0x100c_aafc, -0x5_c2d8);         /* call 0x100caafc */
            ii(0x1012_6dd4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_6dd7, 3);  mov(al, memb[ds, eax + 7]);           /* mov al, [eax+0x7] */
            ii(0x1012_6dda, 5);  mov(memb[ds, 0x101c_3915], al);       /* mov [0x101c3915], al */
            ii(0x1012_6ddf, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_6de1, 6);  mov(dl, memb[ds, 0x101c_3915]);       /* mov dl, [0x101c3915] */
            ii(0x1012_6de7, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1012_6dec, 5);  call(0x100c_aafc, -0x5_c2f5);         /* call 0x100caafc */
            ii(0x1012_6df1, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6df4, 3);  mov(edx, memd[ds, edx + 9]);          /* mov edx, [edx+0x9] */
            ii(0x1012_6df7, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6dfa, 5);  mov(eax, 0x46);                       /* mov eax, 0x46 */
            ii(0x1012_6dff, 5);  call(0x100c_aafc, -0x5_c308);         /* call 0x100caafc */
            ii(0x1012_6e04, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6e07, 3);  mov(edx, memd[ds, edx + 11]);         /* mov edx, [edx+0xb] */
            ii(0x1012_6e0a, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6e0d, 5);  mov(eax, 0x47);                       /* mov eax, 0x47 */
            ii(0x1012_6e12, 5);  call(0x100c_aafc, -0x5_c31b);         /* call 0x100caafc */
            ii(0x1012_6e17, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6e1a, 3);  mov(edx, memd[ds, edx + 13]);         /* mov edx, [edx+0xd] */
            ii(0x1012_6e1d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6e20, 5);  mov(eax, 0x48);                       /* mov eax, 0x48 */
            ii(0x1012_6e25, 5);  call(0x100c_aafc, -0x5_c32e);         /* call 0x100caafc */
            ii(0x1012_6e2a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_6e2d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_6e2f, 3);  mov(dl, memb[ds, eax + 8]);           /* mov dl, [eax+0x8] */
            ii(0x1012_6e32, 5);  mov(eax, 8);                          /* mov eax, 0x8 */
            ii(0x1012_6e37, 5);  call(0x100c_aafc, -0x5_c340);         /* call 0x100caafc */
            ii(0x1012_6e3c, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6e3f, 3);  mov(edx, memd[ds, edx + 15]);         /* mov edx, [edx+0xf] */
            ii(0x1012_6e42, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6e45, 5);  mov(eax, 0x3c);                       /* mov eax, 0x3c */
            ii(0x1012_6e4a, 5);  call(0x100c_aafc, -0x5_c353);         /* call 0x100caafc */
            ii(0x1012_6e4f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_6e52, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_6e54, 3);  mov(dl, memb[ds, eax + 9]);           /* mov dl, [eax+0x9] */
            ii(0x1012_6e57, 5);  mov(eax, 3);                          /* mov eax, 0x3 */
            ii(0x1012_6e5c, 5);  call(0x100c_aafc, -0x5_c365);         /* call 0x100caafc */
            ii(0x1012_6e61, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_6e64, 3);  mov(al, memb[ds, eax + 10]);          /* mov al, [eax+0xa] */
            ii(0x1012_6e67, 5);  mov(memb[ds, 0x101c_37ca], al);       /* mov [0x101c37ca], al */
            ii(0x1012_6e6c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_6e6e, 6);  mov(dl, memb[ds, 0x101c_37ca]);       /* mov dl, [0x101c37ca] */
            ii(0x1012_6e74, 5);  mov(eax, 0x55);                       /* mov eax, 0x55 */
            ii(0x1012_6e79, 5);  call(0x100c_aafc, -0x5_c382);         /* call 0x100caafc */
            ii(0x1012_6e7e, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6e81, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_6e83, 3);  mov(al, memb[ds, edx + 19]);          /* mov al, [edx+0x13] */
            ii(0x1012_6e86, 6);  mov(memw[ds, 0x101c_3966], ax);       /* mov [0x101c3966], ax */
            ii(0x1012_6e8c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_6e8f, 4);  mov(ax, memw[ds, eax + 20]);          /* mov ax, [eax+0x14] */
            ii(0x1012_6e93, 6);  mov(memw[ds, 0x101c_3968], ax);       /* mov [0x101c3968], ax */
            ii(0x1012_6e99, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6e9c, 3);  mov(edx, memd[ds, edx + 20]);         /* mov edx, [edx+0x14] */
            ii(0x1012_6e9f, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6ea2, 5);  mov(eax, 9);                          /* mov eax, 0x9 */
            ii(0x1012_6ea7, 5);  call(0x100c_aafc, -0x5_c3b0);         /* call 0x100caafc */
            ii(0x1012_6eac, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6eaf, 3);  mov(edx, memd[ds, edx + 22]);         /* mov edx, [edx+0x16] */
            ii(0x1012_6eb2, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6eb5, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1012_6eba, 5);  call(0x100c_aafc, -0x5_c3c3);         /* call 0x100caafc */
            ii(0x1012_6ebf, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6ec2, 3);  mov(edx, memd[ds, edx + 24]);         /* mov edx, [edx+0x18] */
            ii(0x1012_6ec5, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6ec8, 5);  mov(eax, 0xb);                        /* mov eax, 0xb */
            ii(0x1012_6ecd, 5);  call(0x100c_aafc, -0x5_c3d6);         /* call 0x100caafc */
            ii(0x1012_6ed2, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6ed5, 3);  mov(edx, memd[ds, edx + 26]);         /* mov edx, [edx+0x1a] */
            ii(0x1012_6ed8, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6edb, 5);  mov(eax, 0xc);                        /* mov eax, 0xc */
            ii(0x1012_6ee0, 5);  call(0x100c_aafc, -0x5_c3e9);         /* call 0x100caafc */
            ii(0x1012_6ee5, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6ee8, 3);  mov(edx, memd[ds, edx + 28]);         /* mov edx, [edx+0x1c] */
            ii(0x1012_6eeb, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6eee, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x1012_6ef3, 5);  call(0x100c_aafc, -0x5_c3fc);         /* call 0x100caafc */
            ii(0x1012_6ef8, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6efb, 3);  mov(edx, memd[ds, edx + 30]);         /* mov edx, [edx+0x1e] */
            ii(0x1012_6efe, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6f01, 5);  mov(eax, 0xe);                        /* mov eax, 0xe */
            ii(0x1012_6f06, 5);  call(0x100c_aafc, -0x5_c40f);         /* call 0x100caafc */
            ii(0x1012_6f0b, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6f0e, 3);  mov(edx, memd[ds, edx + 32]);         /* mov edx, [edx+0x20] */
            ii(0x1012_6f11, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6f14, 5);  mov(eax, 0xf);                        /* mov eax, 0xf */
            ii(0x1012_6f19, 5);  call(0x100c_aafc, -0x5_c422);         /* call 0x100caafc */
            ii(0x1012_6f1e, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6f21, 3);  mov(edx, memd[ds, edx + 34]);         /* mov edx, [edx+0x22] */
            ii(0x1012_6f24, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6f27, 5);  mov(eax, 0x10);                       /* mov eax, 0x10 */
            ii(0x1012_6f2c, 5);  call(0x100c_aafc, -0x5_c435);         /* call 0x100caafc */
            ii(0x1012_6f31, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6f34, 3);  mov(edx, memd[ds, edx + 36]);         /* mov edx, [edx+0x24] */
            ii(0x1012_6f37, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6f3a, 5);  mov(eax, 0x11);                       /* mov eax, 0x11 */
            ii(0x1012_6f3f, 5);  call(0x100c_aafc, -0x5_c448);         /* call 0x100caafc */
            ii(0x1012_6f44, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6f47, 3);  mov(edx, memd[ds, edx + 38]);         /* mov edx, [edx+0x26] */
            ii(0x1012_6f4a, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6f4d, 5);  mov(eax, 0x12);                       /* mov eax, 0x12 */
            ii(0x1012_6f52, 5);  call(0x100c_aafc, -0x5_c45b);         /* call 0x100caafc */
            ii(0x1012_6f57, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6f5a, 3);  mov(edx, memd[ds, edx + 40]);         /* mov edx, [edx+0x28] */
            ii(0x1012_6f5d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6f60, 5);  mov(eax, 0x13);                       /* mov eax, 0x13 */
            ii(0x1012_6f65, 5);  call(0x100c_aafc, -0x5_c46e);         /* call 0x100caafc */
            ii(0x1012_6f6a, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6f6d, 3);  mov(edx, memd[ds, edx + 42]);         /* mov edx, [edx+0x2a] */
            ii(0x1012_6f70, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6f73, 5);  mov(eax, 0x14);                       /* mov eax, 0x14 */
            ii(0x1012_6f78, 5);  call(0x100c_aafc, -0x5_c481);         /* call 0x100caafc */
            ii(0x1012_6f7d, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6f80, 3);  mov(edx, memd[ds, edx + 44]);         /* mov edx, [edx+0x2c] */
            ii(0x1012_6f83, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6f86, 5);  mov(eax, 0x15);                       /* mov eax, 0x15 */
            ii(0x1012_6f8b, 5);  call(0x100c_aafc, -0x5_c494);         /* call 0x100caafc */
            ii(0x1012_6f90, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6f93, 3);  mov(edx, memd[ds, edx + 46]);         /* mov edx, [edx+0x2e] */
            ii(0x1012_6f96, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6f99, 5);  mov(eax, 0x16);                       /* mov eax, 0x16 */
            ii(0x1012_6f9e, 5);  call(0x100c_aafc, -0x5_c4a7);         /* call 0x100caafc */
            ii(0x1012_6fa3, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6fa6, 3);  mov(edx, memd[ds, edx + 48]);         /* mov edx, [edx+0x30] */
            ii(0x1012_6fa9, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6fac, 5);  mov(eax, 0x17);                       /* mov eax, 0x17 */
            ii(0x1012_6fb1, 5);  call(0x100c_aafc, -0x5_c4ba);         /* call 0x100caafc */
            ii(0x1012_6fb6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6fb9, 3);  mov(edx, memd[ds, edx + 50]);         /* mov edx, [edx+0x32] */
            ii(0x1012_6fbc, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6fbf, 5);  mov(eax, 0x18);                       /* mov eax, 0x18 */
            ii(0x1012_6fc4, 5);  call(0x100c_aafc, -0x5_c4cd);         /* call 0x100caafc */
            ii(0x1012_6fc9, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_6fcc, 3);  mov(edx, memd[ds, edx + 52]);         /* mov edx, [edx+0x34] */
            ii(0x1012_6fcf, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6fd2, 5);  mov(eax, 0x19);                       /* mov eax, 0x19 */
            ii(0x1012_6fd7, 5);  call(0x100c_aafc, -0x5_c4e0);         /* call 0x100caafc */
            ii(0x1012_6fdc, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_6fdf, 3);  mov(edx, memd[ds, eax + 54]);         /* mov edx, [eax+0x36] */
            ii(0x1012_6fe2, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6fe5, 5);  mov(eax, 0x1a);                       /* mov eax, 0x1a */
            ii(0x1012_6fea, 5);  call(0x100c_aafc, -0x5_c4f3);         /* call 0x100caafc */
            ii(0x1012_6fef, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_6ff2, 3);  mov(edx, memd[ds, eax + 56]);         /* mov edx, [eax+0x38] */
            ii(0x1012_6ff5, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_6ff8, 5);  mov(eax, 0x1b);                       /* mov eax, 0x1b */
            ii(0x1012_6ffd, 5);  call(0x100c_aafc, -0x5_c506);         /* call 0x100caafc */
            ii(0x1012_7002, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_7005, 3);  mov(edx, memd[ds, eax + 58]);         /* mov edx, [eax+0x3a] */
            ii(0x1012_7008, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_700b, 5);  mov(eax, 0x1c);                       /* mov eax, 0x1c */
            ii(0x1012_7010, 5);  call(0x100c_aafc, -0x5_c519);         /* call 0x100caafc */
            ii(0x1012_7015, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_7018, 3);  mov(edx, memd[ds, eax + 60]);         /* mov edx, [eax+0x3c] */
            ii(0x1012_701b, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_701e, 5);  mov(eax, 0x1d);                       /* mov eax, 0x1d */
            ii(0x1012_7023, 5);  call(0x100c_aafc, -0x5_c52c);         /* call 0x100caafc */
            ii(0x1012_7028, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_702b, 3);  mov(edx, memd[ds, eax + 62]);         /* mov edx, [eax+0x3e] */
            ii(0x1012_702e, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_7031, 5);  mov(eax, 0x2b);                       /* mov eax, 0x2b */
            ii(0x1012_7036, 5);  call(0x100c_aafc, -0x5_c53f);         /* call 0x100caafc */
            ii(0x1012_703b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_703e, 3);  mov(edx, memd[ds, eax + 64]);         /* mov edx, [eax+0x40] */
            ii(0x1012_7041, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1012_7044, 5);  mov(eax, 0x2c);                       /* mov eax, 0x2c */
            ii(0x1012_7049, 5);  call(0x100c_aafc, -0x5_c552);         /* call 0x100caafc */
            ii(0x1012_704e, 7);  cmp(memb[ds, 0x101c_391e], 3);        /* cmp byte [0x101c391e], 0x3 */
            ii(0x1012_7055, 2);  if(jnz(0x1012_7099, 0x42)) goto l_0x1012_7099;/* jnz 0x10127099 */
            ii(0x1012_7057, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_705a, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_705c, 5);  mov(memb[ds, 0x101c_391e], al);       /* mov [0x101c391e], al */
            ii(0x1012_7061, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_7064, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_7066, 3);  mov(dl, memb[ds, eax + 1]);           /* mov dl, [eax+0x1] */
            ii(0x1012_7069, 5);  mov(eax, 0x45);                       /* mov eax, 0x45 */
            ii(0x1012_706e, 5);  call(0x100c_aafc, -0x5_c577);         /* call 0x100caafc */
            ii(0x1012_7073, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_7076, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_7078, 3);  mov(dl, memb[ds, eax + 2]);           /* mov dl, [eax+0x2] */
            ii(0x1012_707b, 5);  mov(eax, 0x3d);                       /* mov eax, 0x3d */
            ii(0x1012_7080, 5);  call(0x100c_aafc, -0x5_c589);         /* call 0x100caafc */
            ii(0x1012_7085, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_7088, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_708a, 3);  mov(dl, memb[ds, eax + 3]);           /* mov dl, [eax+0x3] */
            ii(0x1012_708d, 5);  mov(eax, 0x3e);                       /* mov eax, 0x3e */
            ii(0x1012_7092, 5);  call(0x100c_aafc, -0x5_c59b);         /* call 0x100caafc */
            ii(0x1012_7097, 2);  jmp(0x1012_70f2, 0x59); goto l_0x1012_70f2;/* jmp 0x101270f2 */
        l_0x1012_7099:
            ii(0x1012_7099, 6);  mov(dl, memb[ds, 0x101c_3920]);       /* mov dl, [0x101c3920] */
            ii(0x1012_709f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_70a2, 3);  cmp(dl, memb[ds, eax + 5]);           /* cmp dl, [eax+0x5] */
            ii(0x1012_70a5, 2);  if(jz(0x1012_70b7, 0x10)) goto l_0x1012_70b7;/* jz 0x101270b7 */
            ii(0x1012_70a7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_70aa, 3);  mov(al, memb[ds, eax + 5]);           /* mov al, [eax+0x5] */
            ii(0x1012_70ad, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_70b2, 5);  call(0x1007_1cca, -0xb_53ed);         /* call 0x10071cca */
        l_0x1012_70b7:
            ii(0x1012_70b7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_70ba, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_70bd, 4);  cmp(ax, memw[ds, edx + 11]);          /* cmp ax, [edx+0xb] */
            ii(0x1012_70c1, 2);  if(jnz(0x1012_70cf, 0xc)) goto l_0x1012_70cf;/* jnz 0x101270cf */
            ii(0x1012_70c3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_70c6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_70c9, 4);  cmp(ax, memw[ds, edx + 13]);          /* cmp ax, [edx+0xd] */
            ii(0x1012_70cd, 2);  if(jz(0x1012_70f2, 0x23)) goto l_0x1012_70f2;/* jz 0x101270f2 */
        l_0x1012_70cf:
            ii(0x1012_70cf, 5);  call(0x100c_aa00, -0x5_c6d4);         /* call 0x100caa00 */
            ii(0x1012_70d4, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_70d9, 1);  push(eax);                            /* push eax */
            ii(0x1012_70da, 5);  call(0x100c_aa20, -0x5_c6bf);         /* call 0x100caa20 */
            ii(0x1012_70df, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1012_70e1, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1012_70e3, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1012_70e8, 5);  mov(eax, StringDefinitions.NoticeTurnTimersHaveBeenChanged);/* mov eax, 0x101a8204 */
            ii(0x1012_70ed, 5);  call(0x1011_5d23, -0x1_13cf);         /* call 0x10115d23 */
        l_0x1012_70f2:
            ii(0x1012_70f2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_70f4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_70f5, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_70f6, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_70f7, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_70f8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_70f9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_70fa, 1);  ret();                                /* ret */
        }
    }
}
