using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5325-e012f735")]
        public void /* sys */ Method_1019_5325()
        {
            ii(0x1019_5325, 3);  mov(ax, ds);                          /* mov ax, ds */
            ii(0x1019_5328, 2);  mov(gs, eax);                         /* mov gs, eax */
            ii(0x1019_532a, 2);  mov(fs, eax);                         /* mov fs, eax */
            ii(0x1019_532c, 2);  mov(es, eax);                         /* mov es, eax */
            ii(0x1019_532e, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_532f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1019_5331, 1);  push(esi);                            /* push esi */
            ii(0x1019_5332, 1);  push(edi);                            /* push edi */
            ii(0x1019_5333, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_5334, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_5335, 2);  pushd(fs);                            /* push fs */
            ii(0x1019_5337, 2);  pushd(gs);                            /* push gs */
            ii(0x1019_5339, 1);  pushd(es);                            /* push es */
            ii(0x1019_533a, 4);  mov(ax, 0x101);                       /* mov ax, 0x101 */
            ii(0x1019_533e, 4);  mov(dx, memw[ss, ebp + 8]);           /* mov dx, [ebp+0x8] */
            ii(0x1019_5342, 2);  @int(0x31);                           /* int 0x31 */
            ii(0x1019_5344, 4);  mov(ax, 0);                           /* mov ax, 0x0 */
            ii(0x1019_5348, 1);  popd(es);                             /* pop es */
            ii(0x1019_5349, 2);  popd(gs);                             /* pop gs */
            ii(0x1019_534b, 2);  popd(fs);                             /* pop fs */
            ii(0x1019_534d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1019_534e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_534f, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_5350, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_5351, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1019_5352, 1);  ret();                                /* ret */
        }
    }
}
