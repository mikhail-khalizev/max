using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cd4295b0-ea73-4c91-bbb0-9c957b93f67e")]
        public void Method_1007_5331()
        {
            ii(0x1007_5331, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1007_5336, 5); calld(Definitions.sys_check_available_stack_size, 0xf0a17); /* call 0x10165d52 */
            ii(0x1007_533b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_533c, 1); pushd(esi);                             /* push esi */
            ii(0x1007_533d, 1); pushd(edi);                             /* push edi */
            ii(0x1007_533e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_533f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5341, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_5347, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_534a, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_534d, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_5350, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_5354, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_5356, 2); if(jld(0x1007_5364, 0xc)) goto l_0x1007_5364; /* jl 0x10075364 */
            ii(0x1007_5358, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_535b, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_5362, 2); if(jld(0x1007_5366, 0x2)) goto l_0x1007_5366; /* jl 0x10075366 */
        l_0x1007_5364:
            ii(0x1007_5364, 2); jmpd(0x1007_536e, 0x8); goto l_0x1007_536e; /* jmp 0x1007536e */
        l_0x1007_5366:
            ii(0x1007_5366, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_536a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_536c, 2); if(jged(0x1007_5370, 0x2)) goto l_0x1007_5370; /* jge 0x10075370 */
        l_0x1007_536e:
            ii(0x1007_536e, 2); jmpd(0x1007_537c, 0xc); goto l_0x1007_537c; /* jmp 0x1007537c */
        l_0x1007_5370:
            ii(0x1007_5370, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_5373, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_537a, 2); if(jld(0x1007_5388, 0xc)) goto l_0x1007_5388; /* jl 0x10075388 */
        l_0x1007_537c:
            ii(0x1007_537c, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_5383, 5); jmpd(0x1007_5474, 0xec); goto l_0x1007_5474; /* jmp 0x10075474 */
        l_0x1007_5388:
            ii(0x1007_5388, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1007_538c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_538f, 5); calld(0x1007_64fc, 0x1168);             /* call 0x100764fc */
            ii(0x1007_5394, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_5397, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1007_539b, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_539f, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_53a3, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_53a8, 5); calld(0x1010_3541, 0x8e194);            /* call 0x10103541 */
            ii(0x1007_53ad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_53af, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_53b2, 5); calld(0x1007_643c, 0x1085);             /* call 0x1007643c */
            ii(0x1007_53b7, 2); jmpd(0x1007_53c1, 0x8); goto l_0x1007_53c1; /* jmp 0x100753c1 */
        l_0x1007_53b9:
            ii(0x1007_53b9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_53bc, 5); calld(0x1007_6bf8, 0x1837);             /* call 0x10076bf8 */
        l_0x1007_53c1:
            ii(0x1007_53c1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_53c3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_53c6, 5); calld(0x1013_ad71, 0xc59a6);            /* call 0x1013ad71 */
            ii(0x1007_53cb, 2); test(al, al);                           /* test al, al */
            ii(0x1007_53cd, 6); if(jzd(0x1007_5457, 0x84)) goto l_0x1007_5457; /* jz 0x10075457 */
            ii(0x1007_53d3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_53d6, 5); calld(0x1007_63a0, 0xfc5);              /* call 0x100763a0 */
            ii(0x1007_53db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_53dd, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_53e0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1007_53e4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_53e6, 2); if(jnzd(0x1007_53f6, 0xe)) goto l_0x1007_53f6; /* jnz 0x100753f6 */
            ii(0x1007_53e8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_53eb, 5); calld(0x1007_63a0, 0xfb0);              /* call 0x100763a0 */
            ii(0x1007_53f0, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_53f4, 2); if(jnzd(0x1007_53f8, 0x2)) goto l_0x1007_53f8; /* jnz 0x100753f8 */
        l_0x1007_53f6:
            ii(0x1007_53f6, 2); jmpd(0x1007_5411, 0x19); goto l_0x1007_5411; /* jmp 0x10075411 */
        l_0x1007_53f8:
            ii(0x1007_53f8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_53fb, 5); calld(0x1007_63a0, 0xfa0);              /* call 0x100763a0 */
            ii(0x1007_5400, 5); calld(0x1007_6154, 0xd4f);              /* call 0x10076154 */
            ii(0x1007_5405, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1007_540a, 5); cmp(eax, 0xffff);                       /* cmp eax, 0xffff */
            ii(0x1007_540f, 2); if(jnzd(0x1007_5413, 0x2)) goto l_0x1007_5413; /* jnz 0x10075413 */
        l_0x1007_5411:
            ii(0x1007_5411, 2); jmpd(0x1007_5439, 0x26); goto l_0x1007_5439; /* jmp 0x10075439 */
        l_0x1007_5413:
            ii(0x1007_5413, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5416, 5); calld(0x1007_63a0, 0xf85);              /* call 0x100763a0 */
            ii(0x1007_541b, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1007_5422, 2); if(jnzd(0x1007_5437, 0x13)) goto l_0x1007_5437; /* jnz 0x10075437 */
            ii(0x1007_5424, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5427, 5); calld(0x1007_63a0, 0xf74);              /* call 0x100763a0 */
            ii(0x1007_542c, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1007_542f, 3); and(eax, 0x11);                         /* and eax, 0x11 */
            ii(0x1007_5432, 3); cmp(eax, 0x10);                         /* cmp eax, 0x10 */
            ii(0x1007_5435, 2); if(jnzd(0x1007_5439, 0x2)) goto l_0x1007_5439; /* jnz 0x10075439 */
        l_0x1007_5437:
            ii(0x1007_5437, 2); jmpd(0x1007_543b, 0x2); goto l_0x1007_543b; /* jmp 0x1007543b */
        l_0x1007_5439:
            ii(0x1007_5439, 2); jmpd(0x1007_5452, 0x17); goto l_0x1007_5452; /* jmp 0x10075452 */
        l_0x1007_543b:
            ii(0x1007_543b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_543e, 5); calld(0x1007_6408, 0xfc5);              /* call 0x10076408 */
            ii(0x1007_5443, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_5446, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5448, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_544b, 5); calld(0x1007_5f6c, 0xb1c);              /* call 0x10075f6c */
            ii(0x1007_5450, 2); jmpd(0x1007_5474, 0x22); goto l_0x1007_5474; /* jmp 0x10075474 */
        l_0x1007_5452:
            ii(0x1007_5452, 5); jmpd(0x1007_53b9, -0x9e); goto l_0x1007_53b9; /* jmp 0x100753b9 */
        l_0x1007_5457:
            ii(0x1007_5457, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_545e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5460, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_5463, 5); calld(0x1007_5f6c, 0xb04);              /* call 0x10075f6c */
            ii(0x1007_5468, 2); jmpd(0x1007_5474, 0xa); goto l_0x1007_5474; /* jmp 0x10075474 */
        //  ii(0x1007_546a, 10); Недостижимый код.
        l_0x1007_5474:
            ii(0x1007_5474, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_5477, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5479, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_547a, 1); popd(edi);                              /* pop edi */
            ii(0x1007_547b, 1); popd(esi);                              /* pop esi */
            ii(0x1007_547c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_547d, 1); retd(); return;                         /* ret */
        }
    }
}
