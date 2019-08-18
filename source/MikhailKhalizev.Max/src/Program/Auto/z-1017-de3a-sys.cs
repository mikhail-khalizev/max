using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_de3a-e98ff83d")]
        public void /* sys */ Method_1017_de3a()
        {
            ii(0x1017_de3a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_de3b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_de3c, 1); pushd(edx);                             /* push edx */
            ii(0x1017_de3d, 1); pushd(esi);                             /* push esi */
            ii(0x1017_de3e, 1); pushd(edi);                             /* push edi */
            ii(0x1017_de3f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_de40, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_de42, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1017_de48, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1017_de4b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1017_de4e, 5); mov(memd_a32[ds, 0x101c_0695], eax);    /* mov [0x101c0695], eax */
            ii(0x1017_de53, 3); pushd(memd_a32[ss, ebp - 0x8]);         /* push dword [ebp-0x8] */
            ii(0x1017_de56, 5); calld(/* sys */ 0x1019_4a3d, 0x1_6be2); /* call 0x10194a3d */
            ii(0x1017_de5b, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_de5e, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1017_de65, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_de68, 1); leaved();                               /* leave */
            ii(0x1017_de69, 1); popd(edi);                              /* pop edi */
            ii(0x1017_de6a, 1); popd(esi);                              /* pop esi */
            ii(0x1017_de6b, 1); popd(edx);                              /* pop edx */
            ii(0x1017_de6c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_de6d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_de6e, 1); retd(); return;                         /* ret */
        }
    }
}
