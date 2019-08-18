using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f30e4529-18f3-4612-add8-54123e5d0cf4")]
        public void Method_100c_d916()
        {
            ii(0x100c_d916, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_d91b, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8432); /* call 0x10165d52 */
            ii(0x100c_d920, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_d921, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d922, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d923, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d924, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d925, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d927, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_d92d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_d930, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_d933, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_d93a, 2); if(jzd(0x100c_d950, 0x14)) goto l_0x100c_d950; /* jz 0x100cd950 */
            ii(0x100c_d93c, 5); mov(edx, 0x101b_5b68);                  /* mov edx, 0x101b5b68 */
            ii(0x100c_d941, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d944, 5); calld(Definitions.sys_call_dtor_arr, 0x9_866f); /* call 0x10165fb8 */
            ii(0x100c_d949, 5); calld(Definitions.sys_delete_arr, 0x9_868a); /* call 0x10165fd8 */
            ii(0x100c_d94e, 2); jmpd(0x100c_d97f, 0x2f); goto l_0x100c_d97f; /* jmp 0x100cd97f */
        l_0x100c_d950:
            ii(0x100c_d950, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d953, 7); mov(memd_a32[ds, eax + 0xc], 0x101b_5b7c); /* mov dword [eax+0xc], 0x101b5b7c */
            ii(0x100c_d95a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d95d, 4); cmp(memd_a32[ds, eax + 0x8], 0);        /* cmp dword [eax+0x8], 0x0 */
            ii(0x100c_d961, 2); if(jzd(0x100c_d96e, 0xb)) goto l_0x100c_d96e; /* jz 0x100cd96e */
            ii(0x100c_d963, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d966, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_d969, 5); calld(Definitions.sys_delete, 0x9_85f6); /* call 0x10165f64 */
        l_0x100c_d96e:
            ii(0x100c_d96e, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_d975, 2); if(jzd(0x100c_d97f, 0x8)) goto l_0x100c_d97f; /* jz 0x100cd97f */
            ii(0x100c_d977, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d97a, 5); calld(Definitions.sys_delete, 0x9_85e5); /* call 0x10165f64 */
        l_0x100c_d97f:
            ii(0x100c_d97f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d982, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_d985, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_d988, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d98a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d98b, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d98c, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d98d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d98e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d98f, 1); retd(); return;                         /* ret */
        }
    }
}
