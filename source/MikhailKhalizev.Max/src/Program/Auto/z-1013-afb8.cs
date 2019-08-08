using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d30e42d2-5857-4751-837d-f40649b1c643")]
        public void Method_1013_afb8()
        {
            ii(0x1013_afb8, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1013_afbd, 5); calld(Definitions.sys_check_available_stack_size, 0x2_ad90); /* call 0x10165d52 */
            ii(0x1013_afc2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_afc3, 1); pushd(esi);                             /* push esi */
            ii(0x1013_afc4, 1); pushd(edi);                             /* push edi */
            ii(0x1013_afc5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_afc6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_afc8, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1013_afce, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_afd1, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_afd4, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1013_afd7, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_afdb, 2); if(jzd(0x1013_b023, 0x46)) goto l_0x1013_b023; /* jz 0x1013b023 */
            ii(0x1013_afdd, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x1013_afe2, 5); calld(Definitions.sys_new, 0x2_ae19);   /* call 0x10165e00 */
            ii(0x1013_afe7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_afea, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_afed, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_aff0, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_aff4, 2); if(jzd(0x1013_b015, 0x1f)) goto l_0x1013_b015; /* jz 0x1013b015 */
            ii(0x1013_aff6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_aff9, 5); calld(0x1008_b410, -0xa_fbee);          /* call 0x1008b410 */
            ii(0x1013_affe, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1013_b001, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_b003, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_b005, 5); calld(0x1013_aecb, -0x13f);             /* call 0x1013aecb */
            ii(0x1013_b00a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_b00d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_b010, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_b013, 2); jmpd(0x1013_b01b, 0x6); goto l_0x1013_b01b; /* jmp 0x1013b01b */
        l_0x1013_b015:
            ii(0x1013_b015, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_b018, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1013_b01b:
            ii(0x1013_b01b, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_b01e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_b021, 2); jmpd(0x1013_b02e, 0xb); goto l_0x1013_b02e; /* jmp 0x1013b02e */
        l_0x1013_b023:
            ii(0x1013_b023, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b026, 5); calld(0x1008_b410, -0xa_fc1b);          /* call 0x1008b410 */
            ii(0x1013_b02b, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1013_b02e:
            ii(0x1013_b02e, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1013_b031, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b034, 5); calld(0x1013_abc3, -0x476);             /* call 0x1013abc3 */
            ii(0x1013_b039, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b03c, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_b03f, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_b042, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b045, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1013_b048, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1013_b04b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b04d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b04e, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b04f, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b050, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b051, 1); retd(); return;                         /* ret */
        }
    }
}
