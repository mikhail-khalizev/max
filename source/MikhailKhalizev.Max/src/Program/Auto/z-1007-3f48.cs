using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_3f48-a35bad74")]
        public void Method_1007_3f48()
        {
            ii(0x1007_3f48, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_3f4d, 5); calld(Definitions.sys_check_available_stack_size, 0xf_1e00); /* call 0x10165d52 */
            ii(0x1007_3f52, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_3f53, 1); pushd(esi);                             /* push esi */
            ii(0x1007_3f54, 1); pushd(edi);                             /* push edi */
            ii(0x1007_3f55, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_3f56, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_3f58, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_3f5e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_3f61, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_3f64, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_3f67, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_3f6b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_3f6d, 2); if(jld(0x1007_3f7b, 0xc)) goto l_0x1007_3f7b; /* jl 0x10073f7b */
            ii(0x1007_3f6f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_3f72, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_3f79, 2); if(jld(0x1007_3f7d, 0x2)) goto l_0x1007_3f7d; /* jl 0x10073f7d */
        l_0x1007_3f7b:
            ii(0x1007_3f7b, 2); jmpd(0x1007_3f85, 0x8); goto l_0x1007_3f85; /* jmp 0x10073f85 */
        l_0x1007_3f7d:
            ii(0x1007_3f7d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_3f81, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_3f83, 2); if(jged(0x1007_3f87, 0x2)) goto l_0x1007_3f87; /* jge 0x10073f87 */
        l_0x1007_3f85:
            ii(0x1007_3f85, 2); jmpd(0x1007_3f93, 0xc); goto l_0x1007_3f93; /* jmp 0x10073f93 */
        l_0x1007_3f87:
            ii(0x1007_3f87, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_3f8a, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_3f91, 2); if(jld(0x1007_3f9f, 0xc)) goto l_0x1007_3f9f; /* jl 0x10073f9f */
        l_0x1007_3f93:
            ii(0x1007_3f93, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_3f9a, 5); jmpd(0x1007_403e, 0x9f); goto l_0x1007_403e; /* jmp 0x1007403e */
        l_0x1007_3f9f:
            ii(0x1007_3f9f, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_3fa3, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_3fa7, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_3fac, 5); calld(0x1010_3541, 0x8_f590);           /* call 0x10103541 */
            ii(0x1007_3fb1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_3fb3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3fb6, 5); calld(0x1007_64b8, 0x24fd);             /* call 0x100764b8 */
        l_0x1007_3fbb:
            ii(0x1007_3fbb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3fbd, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3fc0, 5); calld(0x1013_ad71, 0xc_6dac);           /* call 0x1013ad71 */
            ii(0x1007_3fc5, 2); test(al, al);                           /* test al, al */
            ii(0x1007_3fc7, 2); if(jzd(0x1007_4021, 0x58)) goto l_0x1007_4021; /* jz 0x10074021 */
            ii(0x1007_3fc9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3fcc, 5); calld(0x1007_63a0, 0x23cf);             /* call 0x100763a0 */
            ii(0x1007_3fd1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3fd3, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_3fd6, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_3fda, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_3fdc, 2); if(jnzd(0x1007_3fed, 0xf)) goto l_0x1007_3fed; /* jnz 0x10073fed */
            ii(0x1007_3fde, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3fe1, 5); calld(0x1007_63a0, 0x23ba);             /* call 0x100763a0 */
            ii(0x1007_3fe6, 5); cmp(memw_a32[ds, eax + 0x8], 0xf);      /* cmp word [eax+0x8], 0xf */
            ii(0x1007_3feb, 2); if(jged(0x1007_3fef, 0x2)) goto l_0x1007_3fef; /* jge 0x10073fef */
        l_0x1007_3fed:
            ii(0x1007_3fed, 2); jmpd(0x1007_3ffe, 0xf); goto l_0x1007_3ffe; /* jmp 0x10073ffe */
        l_0x1007_3fef:
            ii(0x1007_3fef, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3ff2, 5); calld(0x1007_63a0, 0x23a9);             /* call 0x100763a0 */
            ii(0x1007_3ff7, 5); cmp(memw_a32[ds, eax + 0x8], 0x14);     /* cmp word [eax+0x8], 0x14 */
            ii(0x1007_3ffc, 2); if(jled(0x1007_4000, 0x2)) goto l_0x1007_4000; /* jle 0x10074000 */
        l_0x1007_3ffe:
            ii(0x1007_3ffe, 2); jmpd(0x1007_4017, 0x17); goto l_0x1007_4017; /* jmp 0x10074017 */
        l_0x1007_4000:
            ii(0x1007_4000, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4003, 5); calld(0x1007_6408, 0x2400);             /* call 0x10076408 */
            ii(0x1007_4008, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_400b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_400d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4010, 5); calld(0x1007_5f6c, 0x1f57);             /* call 0x10075f6c */
            ii(0x1007_4015, 2); jmpd(0x1007_403e, 0x27); goto l_0x1007_403e; /* jmp 0x1007403e */
        l_0x1007_4017:
            ii(0x1007_4017, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_401a, 5); calld(0x1007_6bf8, 0x2bd9);             /* call 0x10076bf8 */
            ii(0x1007_401f, 2); jmpd(0x1007_3fbb, -0x66); goto l_0x1007_3fbb; /* jmp 0x10073fbb */
        l_0x1007_4021:
            ii(0x1007_4021, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_4028, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_402a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_402d, 5); calld(0x1007_5f6c, 0x1f3a);             /* call 0x10075f6c */
            ii(0x1007_4032, 2); jmpd(0x1007_403e, 0xa); goto l_0x1007_403e; /* jmp 0x1007403e */
        //  ii(0x1007_4034, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_4036, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //  ii(0x1007_4039, 5); calld(0x1007_5f6c, 0x1f2e);             /* call 0x10075f6c */
        l_0x1007_403e:
            ii(0x1007_403e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_4041, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4043, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_4044, 1); popd(edi);                              /* pop edi */
            ii(0x1007_4045, 1); popd(esi);                              /* pop esi */
            ii(0x1007_4046, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_4047, 1); retd();                                 /* ret */
        }
    }
}
