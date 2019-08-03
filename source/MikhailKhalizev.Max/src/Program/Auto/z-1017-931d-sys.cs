using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("70bb05cd-28c5-4509-a00d-7484d23b5f9b")]
        public void /* sys */ Method_1017_931d()
        {
            ii(0x1017_931d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_931e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_931f, 1); pushd(edx);                             /* push edx */
            ii(0x1017_9320, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_9322, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_9324:
            ii(0x1017_9324, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1017_9326, 2); test(al, al);                           /* test al, al */
            ii(0x1017_9328, 2); if(jzd(0x1017_933c, 0x12)) goto l_0x1017_933c; /* jz 0x1017933c */
            ii(0x1017_932a, 2); sub(al, 0x41);                          /* sub al, 0x41 */
            ii(0x1017_932c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_932e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1017_9330, 3); cmp(ebx, 0x19);                         /* cmp ebx, 0x19 */
            ii(0x1017_9333, 2); if(jgd(0x1017_9339, 0x4)) goto l_0x1017_9339; /* jg 0x10179339 */
            ii(0x1017_9335, 2); add(al, 0x61);                          /* add al, 0x61 */
            ii(0x1017_9337, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
        l_0x1017_9339:
            ii(0x1017_9339, 1); inc(edx);                               /* inc edx */
            ii(0x1017_933a, 2); jmpd(0x1017_9324, -0x18); goto l_0x1017_9324; /* jmp 0x10179324 */
        l_0x1017_933c:
            ii(0x1017_933c, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_933e, 1); popd(edx);                              /* pop edx */
            ii(0x1017_933f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_9340, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_9341, 1); retd(); return;                         /* ret */
        }
    }
}