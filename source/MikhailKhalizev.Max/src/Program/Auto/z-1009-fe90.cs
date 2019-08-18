using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_fe90-c2ccd07f")]
        public void Method_1009_fe90()
        {
            ii(0x1009_fe90, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_fe95, 5); calld(Definitions.sys_check_available_stack_size, 0xc_5eb8); /* call 0x10165d52 */
            ii(0x1009_fe9a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_fe9b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_fe9c, 1); pushd(esi);                             /* push esi */
            ii(0x1009_fe9d, 1); pushd(edi);                             /* push edi */
            ii(0x1009_fe9e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_fe9f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_fea1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_fea7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_feaa, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_fead, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_feb4, 2); if(jzd(0x1009_feca, 0x14)) goto l_0x1009_feca; /* jz 0x1009feca */
            ii(0x1009_feb6, 5); mov(edx, 0x101b_4888);                  /* mov edx, 0x101b4888 */
            ii(0x1009_febb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_febe, 5); calld(Definitions.sys_call_dtor_arr, 0xc_60f5); /* call 0x10165fb8 */
            ii(0x1009_fec3, 5); calld(Definitions.sys_delete_arr, 0xc_6110); /* call 0x10165fd8 */
            ii(0x1009_fec8, 2); jmpd(0x1009_feeb, 0x21); goto l_0x1009_feeb; /* jmp 0x1009feeb */
        l_0x1009_feca:
            ii(0x1009_feca, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_fecf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fed2, 5); calld(0x1009_fdbc, -0x11b);             /* call 0x1009fdbc */
            ii(0x1009_fed7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_feda, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_fee1, 2); if(jzd(0x1009_feeb, 0x8)) goto l_0x1009_feeb; /* jz 0x1009feeb */
            ii(0x1009_fee3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fee6, 5); calld(Definitions.sys_delete, 0xc_6079); /* call 0x10165f64 */
        l_0x1009_feeb:
            ii(0x1009_feeb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_feee, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_fef1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_fef4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_fef6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_fef7, 1); popd(edi);                              /* pop edi */
            ii(0x1009_fef8, 1); popd(esi);                              /* pop esi */
            ii(0x1009_fef9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_fefa, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_fefb, 1); retd(); return;                         /* ret */
        }
    }
}
