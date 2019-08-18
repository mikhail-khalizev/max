using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0fdc7ea9-99ba-418c-ba87-7f20489df128")]
        public void Method_1008_9084()
        {
            ii(0x1008_9084, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9089, 5); calld(Definitions.sys_check_available_stack_size, 0xd_ccc4); /* call 0x10165d52 */
            ii(0x1008_908e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_908f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9090, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9091, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9092, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9093, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9095, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_909b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_909e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_90a1, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1008_90a8, 2); if(jzd(0x1008_90be, 0x14)) goto l_0x1008_90be; /* jz 0x100890be */
            ii(0x1008_90aa, 5); mov(edx, 0x101b_39dc);                  /* mov edx, 0x101b39dc */
            ii(0x1008_90af, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_90b2, 5); calld(Definitions.sys_call_dtor_arr, 0xd_cf01); /* call 0x10165fb8 */
            ii(0x1008_90b7, 5); calld(Definitions.sys_delete_arr, 0xd_cf1c); /* call 0x10165fd8 */
            ii(0x1008_90bc, 2); jmpd(0x1008_90f2, 0x34); goto l_0x1008_90f2; /* jmp 0x100890f2 */
        l_0x1008_90be:
            ii(0x1008_90be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_90c0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_90c3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_90c6, 5); calld(0x1007_5f6c, -0x1_315f);          /* call 0x10075f6c */
            ii(0x1008_90cb, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1008_90ce, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_90d1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_90d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_90d9, 5); calld(0x100a_284c, 0x1_976e);           /* call 0x100a284c */
            ii(0x1008_90de, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_90e1, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1008_90e8, 2); if(jzd(0x1008_90f2, 0x8)) goto l_0x1008_90f2; /* jz 0x100890f2 */
            ii(0x1008_90ea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_90ed, 5); calld(Definitions.sys_delete, 0xd_ce72); /* call 0x10165f64 */
        l_0x1008_90f2:
            ii(0x1008_90f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_90f5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_90f8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_90fb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_90fd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_90fe, 1); popd(edi);                              /* pop edi */
            ii(0x1008_90ff, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9100, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9101, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9102, 1); retd(); return;                         /* ret */
        }
    }
}
