using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4f1e-e154ccfd")]
        public void Method_1007_4f1e()
        {
            ii(0x1007_4f1e, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_4f23, 5); calld(Definitions.sys_check_available_stack_size, 0xf_0e2a); /* call 0x10165d52 */
            ii(0x1007_4f28, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_4f29, 1); pushd(esi);                             /* push esi */
            ii(0x1007_4f2a, 1); pushd(edi);                             /* push edi */
            ii(0x1007_4f2b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_4f2c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_4f2e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_4f34, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_4f37, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_4f3a, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_4f3d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_4f41, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_4f43, 2); if(jld(0x1007_4f51, 0xc)) goto l_0x1007_4f51; /* jl 0x10074f51 */
            ii(0x1007_4f45, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_4f48, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_4f4f, 2); if(jld(0x1007_4f53, 0x2)) goto l_0x1007_4f53; /* jl 0x10074f53 */
        l_0x1007_4f51:
            ii(0x1007_4f51, 2); jmpd(0x1007_4f5b, 0x8); goto l_0x1007_4f5b; /* jmp 0x10074f5b */
        l_0x1007_4f53:
            ii(0x1007_4f53, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_4f57, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_4f59, 2); if(jged(0x1007_4f5d, 0x2)) goto l_0x1007_4f5d; /* jge 0x10074f5d */
        l_0x1007_4f5b:
            ii(0x1007_4f5b, 2); jmpd(0x1007_4f69, 0xc); goto l_0x1007_4f69; /* jmp 0x10074f69 */
        l_0x1007_4f5d:
            ii(0x1007_4f5d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_4f60, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_4f67, 2); if(jld(0x1007_4f75, 0xc)) goto l_0x1007_4f75; /* jl 0x10074f75 */
        l_0x1007_4f69:
            ii(0x1007_4f69, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_4f70, 5); jmpd(0x1007_502a, 0xb5); goto l_0x1007_502a; /* jmp 0x1007502a */
        l_0x1007_4f75:
            ii(0x1007_4f75, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_4f79, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_4f7d, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_4f82, 5); calld(0x1010_3541, 0x8_e5ba);           /* call 0x10103541 */
            ii(0x1007_4f87, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_4f89, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4f8c, 5); calld(0x1007_64b8, 0x1527);             /* call 0x100764b8 */
        l_0x1007_4f91:
            ii(0x1007_4f91, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4f93, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4f96, 5); calld(0x1013_ad71, 0xc_5dd6);           /* call 0x1013ad71 */
            ii(0x1007_4f9b, 2); test(al, al);                           /* test al, al */
            ii(0x1007_4f9d, 6); if(jzd(0x1007_500d, 0x6a)) goto l_0x1007_500d; /* jz 0x1007500d */
            ii(0x1007_4fa3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4fa6, 5); calld(0x1007_63a0, 0x13f5);             /* call 0x100763a0 */
            ii(0x1007_4fab, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_4fae, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_4fb1, 3); cmp(dl, memb_a32[ds, eax + 0x26]);      /* cmp dl, [eax+0x26] */
            ii(0x1007_4fb4, 2); if(jzd(0x1007_4fd2, 0x1c)) goto l_0x1007_4fd2; /* jz 0x10074fd2 */
            ii(0x1007_4fb6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_4fb9, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_4fbc, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_4fbe, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_4fc1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4fc4, 5); calld(0x1007_63a0, 0x13d7);             /* call 0x100763a0 */
            ii(0x1007_4fc9, 5); calld(0x1007_6074, 0x10a6);             /* call 0x10076074 */
            ii(0x1007_4fce, 2); test(al, al);                           /* test al, al */
            ii(0x1007_4fd0, 2); if(jzd(0x1007_4fd4, 0x2)) goto l_0x1007_4fd4; /* jz 0x10074fd4 */
        l_0x1007_4fd2:
            ii(0x1007_4fd2, 2); jmpd(0x1007_4fea, 0x16); goto l_0x1007_4fea; /* jmp 0x10074fea */
        l_0x1007_4fd4:
            ii(0x1007_4fd4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4fd7, 5); calld(0x1007_636c, 0x1390);             /* call 0x1007636c */
            ii(0x1007_4fdc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_4fde, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_4fe1, 5); calld(0x1007_4bde, -0x408);             /* call 0x10074bde */
            ii(0x1007_4fe6, 2); test(al, al);                           /* test al, al */
            ii(0x1007_4fe8, 2); if(jnzd(0x1007_4fec, 0x2)) goto l_0x1007_4fec; /* jnz 0x10074fec */
        l_0x1007_4fea:
            ii(0x1007_4fea, 2); jmpd(0x1007_5003, 0x17); goto l_0x1007_5003; /* jmp 0x10075003 */
        l_0x1007_4fec:
            ii(0x1007_4fec, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4fef, 5); calld(0x1007_6408, 0x1414);             /* call 0x10076408 */
            ii(0x1007_4ff4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_4ff7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4ff9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_4ffc, 5); calld(0x1007_5f6c, 0xf6b);              /* call 0x10075f6c */
            ii(0x1007_5001, 2); jmpd(0x1007_502a, 0x27); goto l_0x1007_502a; /* jmp 0x1007502a */
        l_0x1007_5003:
            ii(0x1007_5003, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_5006, 5); calld(0x1007_6bf8, 0x1bed);             /* call 0x10076bf8 */
            ii(0x1007_500b, 2); jmpd(0x1007_4f91, -0x7c); goto l_0x1007_4f91; /* jmp 0x10074f91 */
        l_0x1007_500d:
            ii(0x1007_500d, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_5014, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5016, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_5019, 5); calld(0x1007_5f6c, 0xf4e);              /* call 0x10075f6c */
            ii(0x1007_501e, 2); jmpd(0x1007_502a, 0xa); goto l_0x1007_502a; /* jmp 0x1007502a */
        //  ii(0x1007_5020, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_5022, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //  ii(0x1007_5025, 5); calld(0x1007_5f6c, 0xf42);              /* call 0x10075f6c */
        l_0x1007_502a:
            ii(0x1007_502a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_502d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_502f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_5030, 1); popd(edi);                              /* pop edi */
            ii(0x1007_5031, 1); popd(esi);                              /* pop esi */
            ii(0x1007_5032, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_5033, 1); retd(); return;                         /* ret */
        }
    }
}
