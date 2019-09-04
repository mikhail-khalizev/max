using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6b7c-5184d86e")]
        public void /* sys */ Method_1018_6b7c()
        {
            ii(0x1018_6b7c, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_6b7d, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_6b7e, 1);  push(edx);                            /* push edx */
            ii(0x1018_6b7f, 1);  push(esi);                            /* push esi */
            ii(0x1018_6b80, 1);  push(edi);                            /* push edi */
            ii(0x1018_6b81, 6);  mov(edx, memd[ds, 0x101b_de0c]);      /* mov edx, [0x101bde0c] */
        l_0x1018_6b87:
            ii(0x1018_6b87, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1018_6b89, 6);  if(jz_func(0x1018_6e66, 0x2d7)) return;/* jz 0x10186e66 */
            ii(0x1018_6b8f, 3);  mov(eax, memd[ds, edx + 36]);         /* mov eax, [edx+0x24] */
            ii(0x1018_6b92, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1018_6b94, 2);  mov(ebx, memd[ds, edx]);              /* mov ebx, [edx] */
            ii(0x1018_6b96, 3);  add(eax, 0x2c);                       /* add eax, 0x2c */
            ii(0x1018_6b99, 2);  cmp(eax, ebx);                        /* cmp eax, ebx */
            ii(0x1018_6b9b, 2);  if(jnz(0x1018_6bd3, 0x36)) goto l_0x1018_6bd3;/* jnz 0x10186bd3 */
            ii(0x1018_6b9d, 3);  lea(ebx, memd[ds, edx - 8]);          /* lea ebx, [edx-0x8] */
            ii(0x1018_6ba0, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1018_6ba2, 3);  mov(ecx, memd[ds, edx + 8]);          /* mov ecx, [edx+0x8] */
            ii(0x1018_6ba5, 5);  call(/* sys */ 0x1018_6b2b, -0x7f);   /* call 0x10186b2b */
            ii(0x1018_6baa, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1018_6bac, 3);  mov(ecx, memd[ds, ebx + 4]);          /* mov ecx, [ebx+0x4] */
            ii(0x1018_6baf, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1018_6bb1, 2);  if(jnz(0x1018_6bc3, 0x10)) goto l_0x1018_6bc3;/* jnz 0x10186bc3 */
            ii(0x1018_6bb3, 2);  mov(esi, memd[ds, ebx]);              /* mov esi, [ebx] */
            ii(0x1018_6bb5, 3);  mov(di, memw[ds, ebx]);               /* mov di, [ebx] */
            ii(0x1018_6bb8, 3);  shr(esi, 0x10);                       /* shr esi, 0x10 */
            ii(0x1018_6bbb, 2);  mov(ah, 5);                           /* mov ah, 0x5 */
            ii(0x1018_6bbd, 2);  mov(al, 2);                           /* mov al, 0x2 */
            ii(0x1018_6bbf, 2);  @int(0x31);                           /* int 0x31 */
            ii(0x1018_6bc1, 2);  jmp(0x1018_6b87, -0x3c); goto l_0x1018_6b87;/* jmp 0x10186b87 */
        l_0x1018_6bc3:
            ii(0x1018_6bc3, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1018_6bc5, 1);  pushd(es);                            /* push es */
            ii(0x1018_6bc6, 2);  mov(es, eax);                         /* mov es, eax */
            ii(0x1018_6bc8, 2);  mov(ah, 0x49);                        /* mov ah, 0x49 */
            ii(0x1018_6bca, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1018_6bcc, 2);  rcl(eax, 1);                          /* rcl eax, 1 */
            ii(0x1018_6bce, 2);  ror(eax, 1);                          /* ror eax, 1 */
            ii(0x1018_6bd0, 1);  popd(es);                             /* pop es */
            ii(0x1018_6bd1, 2);  jmp(0x1018_6b87, -0x4c); goto l_0x1018_6b87;/* jmp 0x10186b87 */
        l_0x1018_6bd3:
            ii(0x1018_6bd3, 3);  mov(edx, memd[ds, edx + 8]);          /* mov edx, [edx+0x8] */
            ii(0x1018_6bd6, 2);  jmp(0x1018_6b87, -0x51); goto l_0x1018_6b87;/* jmp 0x10186b87 */
        }
    }
}
