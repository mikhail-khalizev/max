using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e0f2-d1fb144a")]
        public void Method_1010_e0f2()
        {
            ii(0x1010_e0f2, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_e0f7, 5); calld(Definitions.sys_check_available_stack_size, 0x5_7c56); /* call 0x10165d52 */
            ii(0x1010_e0fc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_e0fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_e0fe, 1); pushd(edx);                             /* push edx */
            ii(0x1010_e0ff, 1); pushd(esi);                             /* push esi */
            ii(0x1010_e100, 1); pushd(edi);                             /* push edi */
            ii(0x1010_e101, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_e102, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_e104, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_e10a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_e10d, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1010_e112, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e115, 3); mov(al, memb_a32[ds, eax + 0x10]);      /* mov al, [eax+0x10] */
            ii(0x1010_e118, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1010_e11a, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1010_e11d, 5); calld(0x100c_aafc, -0x4_3626);          /* call 0x100caafc */
            ii(0x1010_e122, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_e125, 5); calld(0x1010_de32, -0x2f8);             /* call 0x1010de32 */
            ii(0x1010_e12a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_e12c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_e12d, 1); popd(edi);                              /* pop edi */
            ii(0x1010_e12e, 1); popd(esi);                              /* pop esi */
            ii(0x1010_e12f, 1); popd(edx);                              /* pop edx */
            ii(0x1010_e130, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_e131, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_e132, 1); retd();                                 /* ret */
        }
    }
}
