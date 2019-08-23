using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_41dc-bc05df06")]
        public void Method_1007_41dc()
        {
            ii(0x1007_41dc, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1007_41e1, 5); calld(Definitions.sys_check_available_stack_size, 0xf_1b6c); /* call 0x10165d52 */
            ii(0x1007_41e6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_41e7, 1); pushd(esi);                             /* push esi */
            ii(0x1007_41e8, 1); pushd(edi);                             /* push edi */
            ii(0x1007_41e9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_41ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_41ec, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_41f2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_41f5, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_41f8, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_41fb, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_41ff, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_4201, 2); if(jld(0x1007_420f, 0xc)) goto l_0x1007_420f; /* jl 0x1007420f */
            ii(0x1007_4203, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_4206, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_420d, 2); if(jld(0x1007_4211, 0x2)) goto l_0x1007_4211; /* jl 0x10074211 */
        l_0x1007_420f:
            ii(0x1007_420f, 2); jmpd(0x1007_4219, 0x8); goto l_0x1007_4219; /* jmp 0x10074219 */
        l_0x1007_4211:
            ii(0x1007_4211, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_4215, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_4217, 2); if(jged(0x1007_421b, 0x2)) goto l_0x1007_421b; /* jge 0x1007421b */
        l_0x1007_4219:
            ii(0x1007_4219, 2); jmpd(0x1007_4227, 0xc); goto l_0x1007_4227; /* jmp 0x10074227 */
        l_0x1007_421b:
            ii(0x1007_421b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_421e, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_4225, 2); if(jld(0x1007_4233, 0xc)) goto l_0x1007_4233; /* jl 0x10074233 */
        l_0x1007_4227:
            ii(0x1007_4227, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_422e, 5); jmpd(0x1007_438b, 0x158); goto l_0x1007_438b; /* jmp 0x1007438b */
        l_0x1007_4233:
            ii(0x1007_4233, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_4237, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_423b, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_4240, 5); calld(0x1010_3541, 0x8_f2fc);           /* call 0x10103541 */
            ii(0x1007_4245, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_4247, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_424a, 5); calld(0x1007_64b8, 0x2269);             /* call 0x100764b8 */
        l_0x1007_424f:
            ii(0x1007_424f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4251, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4254, 5); calld(0x1013_ad71, 0xc_6b18);           /* call 0x1013ad71 */
            ii(0x1007_4259, 2); test(al, al);                           /* test al, al */
            ii(0x1007_425b, 6); if(jzd(0x1007_436e, 0x10d)) goto l_0x1007_436e; /* jz 0x1007436e */
            ii(0x1007_4261, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4264, 5); calld(0x1007_63a0, 0x2137);             /* call 0x100763a0 */
            ii(0x1007_4269, 5); cmp(memw_a32[ds, eax + 0x8], 0xe);      /* cmp word [eax+0x8], 0xe */
            ii(0x1007_426e, 2); if(jnzd(0x1007_428a, 0x1a)) goto l_0x1007_428a; /* jnz 0x1007428a */
            ii(0x1007_4270, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4273, 5); calld(0x1007_6408, 0x2190);             /* call 0x10076408 */
            ii(0x1007_4278, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_427b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_427d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4280, 5); calld(0x1007_5f6c, 0x1ce7);             /* call 0x10075f6c */
            ii(0x1007_4285, 5); jmpd(0x1007_438b, 0x101); goto l_0x1007_438b; /* jmp 0x1007438b */
        l_0x1007_428a:
            ii(0x1007_428a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_428d, 5); calld(0x1007_63a0, 0x210e);             /* call 0x100763a0 */
            ii(0x1007_4292, 5); cmp(memw_a32[ds, eax + 0x8], 0xd);      /* cmp word [eax+0x8], 0xd */
            ii(0x1007_4297, 6); if(jnzd(0x1007_4361, 0xc4)) goto l_0x1007_4361; /* jnz 0x10074361 */
            ii(0x1007_429d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_42a0, 5); calld(0x1007_63a0, 0x20fb);             /* call 0x100763a0 */
            ii(0x1007_42a5, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1007_42a9, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_42ac, 2); jmpd(0x1007_42b4, 0x6); goto l_0x1007_42b4; /* jmp 0x100742b4 */
        l_0x1007_42ae:
            ii(0x1007_42ae, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_42b1, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1007_42b4:
            ii(0x1007_42b4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_42b7, 5); calld(0x1007_63a0, 0x20e4);             /* call 0x100763a0 */
            ii(0x1007_42bc, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1007_42bf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_42c2, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1007_42c6, 1); inc(eax);                               /* inc eax */
            ii(0x1007_42c7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_42c9, 6); if(jgd(0x1007_434a, 0x7b)) goto l_0x1007_434a; /* jg 0x1007434a */
            ii(0x1007_42cf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_42d2, 5); calld(0x1007_63a0, 0x20c9);             /* call 0x100763a0 */
            ii(0x1007_42d7, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1007_42db, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_42de, 2); jmpd(0x1007_42e6, 0x6); goto l_0x1007_42e6; /* jmp 0x100742e6 */
        l_0x1007_42e0:
            ii(0x1007_42e0, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_42e3, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x1007_42e6:
            ii(0x1007_42e6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_42e9, 5); calld(0x1007_63a0, 0x20b2);             /* call 0x100763a0 */
            ii(0x1007_42ee, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1007_42f1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_42f4, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1007_42f8, 1); inc(eax);                               /* inc eax */
            ii(0x1007_42f9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_42fb, 2); if(jgd(0x1007_4345, 0x48)) goto l_0x1007_4345; /* jg 0x10074345 */
            ii(0x1007_42fd, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_4300, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1007_4304, 2); if(jnzd(0x1007_430f, 0x9)) goto l_0x1007_430f; /* jnz 0x1007430f */
            ii(0x1007_4306, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_4309, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1007_430d, 2); if(jzd(0x1007_4343, 0x34)) goto l_0x1007_4343; /* jz 0x10074343 */
        l_0x1007_430f:
            ii(0x1007_430f, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1007_4314, 1); pushd(eax);                             /* push eax */
            ii(0x1007_4315, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x1007_4319, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x1007_431d, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1007_4321, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1007_4326, 5); calld(0x1007_02b9, -0x4072);            /* call 0x100702b9 */
            ii(0x1007_432b, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1007_432e, 2); if(jnzd(0x1007_4343, 0x13)) goto l_0x1007_4343; /* jnz 0x10074343 */
            ii(0x1007_4330, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_4337, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4339, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_433c, 5); calld(0x1007_5f6c, 0x1c2b);             /* call 0x10075f6c */
            ii(0x1007_4341, 2); jmpd(0x1007_438b, 0x48); goto l_0x1007_438b; /* jmp 0x1007438b */
        l_0x1007_4343:
            ii(0x1007_4343, 2); jmpd(0x1007_42e0, -0x65); goto l_0x1007_42e0; /* jmp 0x100742e0 */
        l_0x1007_4345:
            ii(0x1007_4345, 5); jmpd(0x1007_42ae, -0x9c); goto l_0x1007_42ae; /* jmp 0x100742ae */
        l_0x1007_434a:
            ii(0x1007_434a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_434d, 5); calld(0x1007_6408, 0x20b6);             /* call 0x10076408 */
            ii(0x1007_4352, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_4355, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4357, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_435a, 5); calld(0x1007_5f6c, 0x1c0d);             /* call 0x10075f6c */
            ii(0x1007_435f, 2); jmpd(0x1007_438b, 0x2a); goto l_0x1007_438b; /* jmp 0x1007438b */
        l_0x1007_4361:
            ii(0x1007_4361, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4364, 5); calld(0x1007_6bf8, 0x288f);             /* call 0x10076bf8 */
            ii(0x1007_4369, 5); jmpd(0x1007_424f, -0x11f); goto l_0x1007_424f; /* jmp 0x1007424f */
        l_0x1007_436e:
            ii(0x1007_436e, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_4375, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4377, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_437a, 5); calld(0x1007_5f6c, 0x1bed);             /* call 0x10075f6c */
            ii(0x1007_437f, 2); jmpd(0x1007_438b, 0xa); goto l_0x1007_438b; /* jmp 0x1007438b */
        //  ii(0x1007_4381, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_4383, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //  ii(0x1007_4386, 5); calld(0x1007_5f6c, 0x1be1);             /* call 0x10075f6c */
        l_0x1007_438b:
            ii(0x1007_438b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_438e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4390, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_4391, 1); popd(edi);                              /* pop edi */
            ii(0x1007_4392, 1); popd(esi);                              /* pop esi */
            ii(0x1007_4393, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_4394, 1); retd();                                 /* ret */
        }
    }
}
