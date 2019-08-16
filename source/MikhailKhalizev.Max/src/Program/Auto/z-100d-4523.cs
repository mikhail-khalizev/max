using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d44836ad-441f-4a9d-b51e-9137fe58b8b1")]
        public void Method_100d_4523()
        {
            ii(0x100d_4523, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_4528, 5); calld(Definitions.sys_check_available_stack_size, 0x9_1825); /* call 0x10165d52 */
            ii(0x100d_452d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_452e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_452f, 1); pushd(edx);                             /* push edx */
            ii(0x100d_4530, 1); pushd(esi);                             /* push esi */
            ii(0x100d_4531, 1); pushd(edi);                             /* push edi */
            ii(0x100d_4532, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_4533, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4535, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_453b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_453e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4541, 6); mov(eax, memd_a32[ds, eax + 0x8d]);     /* mov eax, [eax+0x8d] */
            ii(0x100d_4547, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_454a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_454d, 3); mov(edx, memd_a32[ds, eax + 0x40]);     /* mov edx, [eax+0x40] */
            ii(0x100d_4550, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4553, 3); calld_abs(memd_a32[ds, edx + 0x8]);     /* call dword [edx+0x8] */
            ii(0x100d_4556, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4559, 5); add(eax, 0x87);                         /* add eax, 0x87 */
            ii(0x100d_455e, 5); calld(Definitions.my_2_get_count, -0x4_91fb); /* call 0x1008b368 */
            ii(0x100d_4563, 1); cwde();                                 /* cwde */
            ii(0x100d_4564, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_4566, 2); if(jnzd(0x100d_4577, 0xf)) goto l_0x100d_4577; /* jnz 0x100d4577 */
            ii(0x100d_4568, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_456b, 3); mov(edx, memd_a32[ds, eax + 0x3e]);     /* mov edx, [eax+0x3e] */
            ii(0x100d_456e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4571, 6); mov(memd_a32[ds, eax + 0x91], edx);     /* mov [eax+0x91], edx */
        l_0x100d_4577:
            ii(0x100d_4577, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4579, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_457a, 1); popd(edi);                              /* pop edi */
            ii(0x100d_457b, 1); popd(esi);                              /* pop esi */
            ii(0x100d_457c, 1); popd(edx);                              /* pop edx */
            ii(0x100d_457d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_457e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_457f, 1); retd(); return;                         /* ret */
        }
    }
}