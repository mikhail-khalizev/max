using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9414-463d6159")]
        public void /* sys */ Method_1017_9414()
        {
            ii(0x1017_9414, 5); pushd(0x3f00);                          /* push 0x3f00 */
            ii(0x1017_9419, 1); pushd(ds);                              /* push ds */
            ii(0x1017_941a, 2); mov(ds, ecx);                           /* mov ds, ecx */
            ii(0x1017_941c, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_941e, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1017_9420, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_9422, 4); mov(eax, memd_a32[ss, esp + 0x4]);      /* mov eax, [esp+0x4] */
            ii(0x1017_9426, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_9428, 1); popd(ds);                               /* pop ds */
            ii(0x1017_9429, 1); pushd(ds);                              /* push ds */
            ii(0x1017_942a, 2); if(jbd(0x1017_9432, 0x6)) goto l_0x1017_9432; /* jb 0x10179432 */
            ii(0x1017_942c, 4); mov(ebx, memd_a32[ss, esp + 0xc]);      /* mov ebx, [esp+0xc] */
            ii(0x1017_9430, 2); mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
        l_0x1017_9432:
            ii(0x1017_9432, 5); calld(/* sys */ 0x1018_dc28, 0x1_47f1); /* call 0x1018dc28 */
            ii(0x1017_9437, 1); popd(ds);                               /* pop ds */
            ii(0x1017_9438, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_943b, 3); retd(0x4);                              /* ret 0x4 */
        }
    }
}
