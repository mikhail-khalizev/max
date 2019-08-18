using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5d28115b-1f51-4af3-b026-880b5097368d")]
        public void Method_100c_d3a9()
        {
            ii(0x100c_d3a9, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_d3ae, 5); calld(Definitions.sys_check_available_stack_size, 0x9_899f); /* call 0x10165d52 */
            ii(0x100c_d3b3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_d3b4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d3b5, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d3b6, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d3b7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d3b8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d3ba, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_d3c0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_d3c3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_d3c6, 5); mov(edx, StringDefinitions.UpgradUnit); /* mov edx, 0x101a145e */
            ii(0x100c_d3cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d3ce, 5); calld(Definitions.sys_strcpy, 0x9_8afc); /* call 0x10165ecf */
            ii(0x100c_d3d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d3d6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_d3d9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_d3dc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d3de, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d3df, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d3e0, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d3e1, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d3e2, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d3e3, 1); retd(); return;                         /* ret */
        }
    }
}
