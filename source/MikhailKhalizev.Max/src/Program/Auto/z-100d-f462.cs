using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("498312e5-e8d5-4a29-8a2e-e9c214084e9b")]
        public void Method_100d_f462()
        {
            ii(0x100d_f462, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x100d_f467, 5); calld(Definitions.sys_check_available_stack_size, 0x868e6); /* call 0x10165d52 */
            ii(0x100d_f46c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_f46d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_f46e, 1); pushd(edx);                             /* push edx */
            ii(0x100d_f46f, 1); pushd(esi);                             /* push esi */
            ii(0x100d_f470, 1); pushd(edi);                             /* push edi */
            ii(0x100d_f471, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_f472, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_f474, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100d_f47a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_f47d, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100d_f481, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f484, 5); calld(0x100e_0608, 0x117f);             /* call 0x100e0608 */
            ii(0x100d_f489, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_f48c, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100d_f490, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x100d_f497, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f49a, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_f49f, 5); calld(0x100e_0cf0, 0x184c);             /* call 0x100e0cf0 */
            ii(0x100d_f4a4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f4a6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f4a9, 5); calld(0x100e_0548, 0x109a);             /* call 0x100e0548 */
            ii(0x100d_f4ae, 2); jmpd(0x100d_f4b8, 0x8); goto l_0x100d_f4b8; /* jmp 0x100df4b8 */
        l_0x100d_f4b0:
            ii(0x100d_f4b0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f4b3, 5); calld(0x1007_6bf8, -0x688c0);           /* call 0x10076bf8 */
        l_0x100d_f4b8:
            ii(0x100d_f4b8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f4ba, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f4bd, 5); calld(0x1013_ad71, 0x5b8af);            /* call 0x1013ad71 */
            ii(0x100d_f4c2, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f4c4, 2); if(jzd(0x100d_f4d9, 0x13)) goto l_0x100d_f4d9; /* jz 0x100df4d9 */
            ii(0x100d_f4c6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f4c9, 5); calld(0x100e_047c, 0xfae);              /* call 0x100e047c */
            ii(0x100d_f4ce, 5); calld(0x100e_0d64, 0x1891);             /* call 0x100e0d64 */
            ii(0x100d_f4d3, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_f4d7, 2); if(jzd(0x100d_f4db, 0x2)) goto l_0x100d_f4db; /* jz 0x100df4db */
        l_0x100d_f4d9:
            ii(0x100d_f4d9, 2); jmpd(0x100d_f4e3, 0x8); goto l_0x100d_f4e3; /* jmp 0x100df4e3 */
        l_0x100d_f4db:
            ii(0x100d_f4db, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_f4de, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
            ii(0x100d_f4e1, 2); jmpd(0x100d_f4b0, -0x33); goto l_0x100d_f4b0; /* jmp 0x100df4b0 */
        l_0x100d_f4e3:
            ii(0x100d_f4e3, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x100d_f4e8, 5); calld(Definitions.sys_new, 0x86913);    /* call 0x10165e00 */
            ii(0x100d_f4ed, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_f4f0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_f4f3, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_f4f6, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100d_f4fa, 2); if(jzd(0x100d_f513, 0x17)) goto l_0x100d_f513; /* jz 0x100df513 */
            ii(0x100d_f4fc, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100d_f500, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_f503, 5); calld(0x1016_3dd9, 0x848d1);            /* call 0x10163dd9 */
            ii(0x100d_f508, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_f50b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_f50e, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100d_f511, 2); jmpd(0x100d_f519, 0x6); goto l_0x100d_f519; /* jmp 0x100df519 */
        l_0x100d_f513:
            ii(0x100d_f513, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_f516, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100d_f519:
            ii(0x100d_f519, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100d_f51c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_f51f, 3); mov(ebx, memd_a32[ss, ebp - 0x1c]);     /* mov ebx, [ebp-0x1c] */
            ii(0x100d_f522, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f525, 5); calld(0x100e_0518, 0xfee);              /* call 0x100e0518 */
            ii(0x100d_f52a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f52c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f52f, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_f534, 5); calld(0x100e_0c8c, 0x1753);             /* call 0x100e0c8c */
            ii(0x100d_f539, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_f53c, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100d_f53f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f541, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f544, 5); calld(0x100e_043c, 0xef3);              /* call 0x100e043c */
            ii(0x100d_f549, 2); jmpd(0x100d_f555, 0xa); goto l_0x100d_f555; /* jmp 0x100df555 */
        //  ii(0x100d_f54b, 10); Недостижимый код.
l_0x100d_f555:
            ii(0x100d_f555, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100d_f558, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_f55a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_f55b, 1); popd(edi);                              /* pop edi */
            ii(0x100d_f55c, 1); popd(esi);                              /* pop esi */
            ii(0x100d_f55d, 1); popd(edx);                              /* pop edx */
            ii(0x100d_f55e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_f55f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_f560, 1); retd(); return;                         /* ret */
        }
    }
}
