using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a064-249d3276")]
        public void Method_1008_a064()
        {
            ii(0x1008_a064, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a069, 5); calld(Definitions.sys_check_available_stack_size, 0xd_bce4); /* call 0x10165d52 */
            ii(0x1008_a06e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a06f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a070, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a071, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a072, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a073, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a074, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a076, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a07c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a07f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a082, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x1008_a085, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_a088, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_a08b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a08d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a08e, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a08f, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a090, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a091, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a092, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a093, 1); retd();                                 /* ret */
        }
    }
}
