using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4d46-eac87b97")]
        public void /* sys */ Method_1019_4d46()
        {
            ii(0x1019_4d46, 1);  push(eax);                            /* push eax */
            ii(0x1019_4d47, 3);  mov(ax, ds);                          /* mov ax, ds */
            ii(0x1019_4d4a, 2);  mov(gs, eax);                         /* mov gs, eax */
            ii(0x1019_4d4c, 2);  mov(ds, eax);                         /* mov ds, eax */
            ii(0x1019_4d4e, 1);  pop(eax);                             /* pop eax */
            ii(0x1019_4d4f, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_4d50, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1019_4d52, 1);  push(esi);                            /* push esi */
            ii(0x1019_4d53, 1);  push(edi);                            /* push edi */
            ii(0x1019_4d54, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_4d55, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_4d56, 2);  pushd(fs);                            /* push fs */
            ii(0x1019_4d58, 2);  pushd(gs);                            /* push gs */
            ii(0x1019_4d5a, 1);  pushd(es);                            /* push es */
            ii(0x1019_4d5b, 4);  mov(si, memw[ss, ebp + 16]);          /* mov si, [ebp+0x10] */
            ii(0x1019_4d5f, 4);  mov(di, memw[ss, ebp + 18]);          /* mov di, [ebp+0x12] */
            ii(0x1019_4d63, 4);  mov(ax, 0x502);                       /* mov ax, 0x502 */
            ii(0x1019_4d67, 2);  @int(0x31);                           /* int 0x31 */
            ii(0x1019_4d69, 4);  mov(ax, 1);                           /* mov ax, 0x1 */
            ii(0x1019_4d6d, 4);  mov(bx, memw[ss, ebp + 12]);          /* mov bx, [ebp+0xc] */
            ii(0x1019_4d71, 2);  @int(0x31);                           /* int 0x31 */
            ii(0x1019_4d73, 1);  popd(es);                             /* pop es */
            ii(0x1019_4d74, 2);  popd(gs);                             /* pop gs */
            ii(0x1019_4d76, 2);  popd(fs);                             /* pop fs */
            ii(0x1019_4d78, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1019_4d79, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_4d7a, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_4d7b, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_4d7c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1019_4d7d, 1);  ret();                                /* ret */
        }
    }
}
