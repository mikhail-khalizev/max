using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_6677-d2ed5f24")]
        public void Method_100c_6677()
        {
            ii(0x100c_6677, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100c_667c, 5); calld(Definitions.sys_check_available_stack_size, 0x9_f6d1); /* call 0x10165d52 */
            ii(0x100c_6681, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_6682, 1); pushd(esi);                             /* push esi */
            ii(0x100c_6683, 1); pushd(edi);                             /* push edi */
            ii(0x100c_6684, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_6685, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_6687, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100c_668d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_6690, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_6693, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100c_6696, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x100c_669a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_669d, 5); calld(0x100c_9fb4, 0x3912);             /* call 0x100c9fb4 */
            ii(0x100c_66a2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_66a5, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100c_66a9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_66ac, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100c_66af, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_66b2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_66b4, 2); if(jged(0x100c_6701, 0x4b)) goto l_0x100c_6701; /* jge 0x100c6701 */
            ii(0x100c_66b6, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100c_66bd, 2); jmpd(0x100c_66c5, 0x6); goto l_0x100c_66c5; /* jmp 0x100c66c5 */
        l_0x100c_66bf:
            ii(0x100c_66bf, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_66c2, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100c_66c5:
            ii(0x100c_66c5, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_66c9, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100c_66cc, 2); if(jged(0x100c_6701, 0x33)) goto l_0x100c_6701; /* jge 0x100c6701 */
            ii(0x100c_66ce, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_66d1, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100c_66d4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_66d7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_66d9, 2); if(jld(0x100c_66f5, 0x1a)) goto l_0x100c_66f5; /* jl 0x100c66f5 */
            ii(0x100c_66db, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_66df, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_66e5, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100c_66eb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_66f0, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_66f3, 2); if(jzd(0x100c_66ff, 0xa)) goto l_0x100c_66ff; /* jz 0x100c66ff */
        l_0x100c_66f5:
            ii(0x100c_66f5, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_66f8, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_66fb, 4); mov(memw_a32[ds, edx + 0x7b], ax);      /* mov [edx+0x7b], ax */
        l_0x100c_66ff:
            ii(0x100c_66ff, 2); jmpd(0x100c_66bf, -0x42); goto l_0x100c_66bf; /* jmp 0x100c66bf */
        l_0x100c_6701:
            ii(0x100c_6701, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6704, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100c_6707, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_670a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_670c, 6); if(jld_func(0x100c_693c, 0x22a)) return; /* jl 0x100c693c */
            ii(0x100c_6712, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6716, 6); if(jzd_func(0x100c_67d6, 0xba)) return; /* jz 0x100c67d6 */
            ii(0x100c_671c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_671f, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x100c_6722, 3); mov(memb_a32[ss, ebp - 0x20], al);      /* mov [ebp-0x20], al */
            ii(0x100c_6725, 5); if(jmpd_func(0x100c_67b4, 0x8a)) return; /* jmp 0x100c67b4 */
            ii(0x100c_672a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_672c, 1); pushd(eax);                             /* push eax */
            ii(0x100c_672d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6730, 3); mov(ecx, memd_a32[ds, eax + 0x79]);     /* mov ecx, [eax+0x79] */
            ii(0x100c_6733, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_6736, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6739, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_673c, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_6741, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6744, 5); calld(0x100c_6542, -0x207);             /* call 0x100c6542 */
            ii(0x100c_6749, 5); if(jmpd_func(0x100c_67d1, 0x83)) return; /* jmp 0x100c67d1 */
            ii(0x100c_674e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_6753, 1); pushd(eax);                             /* push eax */
            ii(0x100c_6754, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6757, 3); mov(ecx, memd_a32[ds, eax + 0x79]);     /* mov ecx, [eax+0x79] */
            ii(0x100c_675a, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_675d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6760, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_6763, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x100c_6768, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_676b, 5); calld(0x100c_6542, -0x22e);             /* call 0x100c6542 */
            ii(0x100c_6770, 2); if(jmpd_func(0x100c_67d1, 0x5f)) return; /* jmp 0x100c67d1 */
            ii(0x100c_6772, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_6777, 1); pushd(eax);                             /* push eax */
            ii(0x100c_6778, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_677b, 3); mov(ecx, memd_a32[ds, eax + 0x79]);     /* mov ecx, [eax+0x79] */
            ii(0x100c_677e, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_6781, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6784, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_6787, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_678c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_678f, 5); calld(0x100c_6542, -0x252);             /* call 0x100c6542 */
            ii(0x100c_6794, 2); if(jmpd_func(0x100c_67d1, 0x3b)) return; /* jmp 0x100c67d1 */
        }
    }
}
