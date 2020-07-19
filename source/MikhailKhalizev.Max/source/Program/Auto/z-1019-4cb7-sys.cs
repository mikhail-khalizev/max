using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4cb7-1284c9d1")]
        public void /* sys */ Method_1019_4cb7()
        {
            ii(0x1019_4cb7, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_4cb8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1019_4cba, 1);  push(esi);                            /* push esi */
            ii(0x1019_4cbb, 1);  push(edi);                            /* push edi */
            ii(0x1019_4cbc, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_4cbd, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_4cbe, 2);  pushd(fs);                            /* push fs */
            ii(0x1019_4cc0, 2);  pushd(gs);                            /* push gs */
            ii(0x1019_4cc2, 1);  pushd(es);                            /* push es */
            ii(0x1019_4cc3, 4);  mov(ax, 0);                           /* mov ax, 0x0 */
            ii(0x1019_4cc7, 4);  mov(cx, 1);                           /* mov cx, 0x1 */
            ii(0x1019_4ccb, 2);  @int(0x31);                           /* int 0x31 */
            ii(0x1019_4ccd, 1);  push(eax);                            /* push eax */
            ii(0x1019_4cce, 4);  mov(memw[ss, ebp - 2], ax);           /* mov [ebp-0x2], ax */
            ii(0x1019_4cd2, 1);  push(eax);                            /* push eax */
            ii(0x1019_4cd3, 3);  mov(bx, ax);                          /* mov bx, ax */
            ii(0x1019_4cd6, 4);  mov(ax, 8);                           /* mov ax, 0x8 */
            ii(0x1019_4cda, 3);  xor(cx, cx);                          /* xor cx, cx */
            ii(0x1019_4cdd, 3);  mov(edx, memd[ss, ebp + 8]);          /* mov edx, [ebp+0x8] */
            ii(0x1019_4ce0, 2);  @int(0x31);                           /* int 0x31 */
            ii(0x1019_4ce2, 1);  pop(eax);                             /* pop eax */
            ii(0x1019_4ce3, 4);  mov(ax, 0x501);                       /* mov ax, 0x501 */
            ii(0x1019_4ce7, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1019_4ce9, 3);  mov(ecx, memd[ss, ebp + 8]);          /* mov ecx, [ebp+0x8] */
            ii(0x1019_4cec, 4);  add(cx, 0x50);                        /* add cx, 0x50 */
            ii(0x1019_4cf0, 2);  @int(0x31);                           /* int 0x31 */
            ii(0x1019_4cf2, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_4cf3, 3);  mov(ebx, memd[ss, ebp + 12]);         /* mov ebx, [ebp+0xc] */
            ii(0x1019_4cf6, 3);  mov(memw[ds, ebx], si);               /* mov [ebx], si */
            ii(0x1019_4cf9, 4);  mov(memw[ds, ebx + 2], di);           /* mov [ebx+0x2], di */
            ii(0x1019_4cfd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_4cfe, 4);  mov(ax, 0x6100);                      /* mov ax, 0x6100 */
            ii(0x1019_4d02, 3);  xor(si, si);                          /* xor si, si */
            ii(0x1019_4d05, 4);  mov(di, memw[ss, ebp + 8]);           /* mov di, [ebp+0x8] */
            ii(0x1019_4d09, 1);  pop(eax);                             /* pop eax */
            ii(0x1019_4d0a, 1);  push(eax);                            /* push eax */
            ii(0x1019_4d0b, 3);  mov(dx, cx);                          /* mov dx, cx */
            ii(0x1019_4d0e, 3);  mov(cx, bx);                          /* mov cx, bx */
            ii(0x1019_4d11, 3);  mov(bx, ax);                          /* mov bx, ax */
            ii(0x1019_4d14, 4);  mov(ax, 7);                           /* mov ax, 0x7 */
            ii(0x1019_4d18, 2);  @int(0x31);                           /* int 0x31 */
            ii(0x1019_4d1a, 4);  movzx(ecx, memw[ss, ebp - 2]);        /* movzx ecx, word [ebp-0x2] */
            ii(0x1019_4d1e, 3);  lar(ecx, cx);                         /* lar ecx, cx */
            ii(0x1019_4d21, 3);  shr(ecx, 8);                          /* shr ecx, 0x8 */
            ii(0x1019_4d24, 5);  or(cx, 0x4000);                       /* or cx, 0x4000 */
            ii(0x1019_4d29, 4);  mov(bx, memw[ss, ebp - 2]);           /* mov bx, [ebp-0x2] */
            ii(0x1019_4d2d, 4);  mov(ax, 9);                           /* mov ax, 0x9 */
            ii(0x1019_4d31, 2);  @int(0x31);                           /* int 0x31 */
            ii(0x1019_4d33, 1);  pop(eax);                             /* pop eax */
            ii(0x1019_4d34, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1019_4d36, 3);  mov(dx, ax);                          /* mov dx, ax */
            ii(0x1019_4d39, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1019_4d3b, 1);  popd(es);                             /* pop es */
            ii(0x1019_4d3c, 2);  popd(gs);                             /* pop gs */
            ii(0x1019_4d3e, 2);  popd(fs);                             /* pop fs */
            ii(0x1019_4d40, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1019_4d41, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_4d42, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_4d43, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_4d44, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1019_4d45, 1);  ret();                                /* ret */
        }
    }
}
