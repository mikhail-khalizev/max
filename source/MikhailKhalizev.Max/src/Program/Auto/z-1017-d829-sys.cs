using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("49beaeaa-98f2-484c-b69c-f66f94e0e5cb")]
        public void /* sys */ Method_1017_d829()
        {
            ii(0x1017_d829, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_d82a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_d82b, 1); pushd(esi);                             /* push esi */
            ii(0x1017_d82c, 1); pushd(edi);                             /* push edi */
            ii(0x1017_d82d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_d82e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_d830, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1017_d836, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1017_d839, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1017_d83c, 4); test(memb_a32[ss, ebp - 0xc], 0x2);     /* test byte [ebp-0xc], 0x2 */
            ii(0x1017_d840, 2); if(jzd(0x1017_d84b, 0x9)) goto l_0x1017_d84b; /* jz 0x1017d84b */
            ii(0x1017_d842, 7); mov(memb_a32[ds, 0x101c_1a58], 0x1);    /* mov byte [0x101c1a58], 0x1 */
            ii(0x1017_d849, 2); jmpd(0x1017_d852, 0x7); goto l_0x1017_d852; /* jmp 0x1017d852 */
        l_0x1017_d84b:
            ii(0x1017_d84b, 7); mov(memb_a32[ds, 0x101c_1a58], 0);      /* mov byte [0x101c1a58], 0x0 */
        l_0x1017_d852:
            ii(0x1017_d852, 4); test(memb_a32[ss, ebp - 0xc], 0x1);     /* test byte [ebp-0xc], 0x1 */
            ii(0x1017_d856, 2); if(jnzd(0x1017_d884, 0x2c)) goto l_0x1017_d884; /* jnz 0x1017d884 */
            ii(0x1017_d858, 7); mov(memb_a32[ds, 0x101c_1a54], 0x1);    /* mov byte [0x101c1a54], 0x1 */
            ii(0x1017_d85f, 5); calld(/* sys */ 0x1019_4b45, 0x1_72e1); /* call 0x10194b45 */
            ii(0x1017_d864, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1017_d866, 5); mov(edx, /* sys */ 0x1017_de6f);        /* mov edx, 0x1017de6f */
            ii(0x1017_d86b, 3); movzx(eax, ax);                         /* movzx eax, ax */
            ii(0x1017_d86e, 1); pushd(eax);                             /* push eax */
            ii(0x1017_d86f, 1); pushd(edx);                             /* push edx */
            ii(0x1017_d870, 5); pushd(0xffff);                          /* push 0xffff */
            ii(0x1017_d875, 5); calld(/* sys */ 0x1019_4a83, 0x1_7209); /* call 0x10194a83 */
            ii(0x1017_d87a, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1017_d87d, 5); calld(/* sys */ 0x1019_4b71, 0x1_72ef); /* call 0x10194b71 */
            ii(0x1017_d882, 2); jmpd(0x1017_d88b, 0x7); goto l_0x1017_d88b; /* jmp 0x1017d88b */
        l_0x1017_d884:
            ii(0x1017_d884, 7); mov(memb_a32[ds, 0x101c_1a54], 0);      /* mov byte [0x101c1a54], 0x0 */
        l_0x1017_d88b:
            ii(0x1017_d88b, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1017_d88f, 2); if(jzd(0x1017_d897, 0x6)) goto l_0x1017_d897; /* jz 0x1017d897 */
            ii(0x1017_d891, 4); test(memb_a32[ss, ebp - 0xc], 0x1);     /* test byte [ebp-0xc], 0x1 */
            ii(0x1017_d895, 2); if(jzd(0x1017_d899, 0x2)) goto l_0x1017_d899; /* jz 0x1017d899 */
        l_0x1017_d897:
            ii(0x1017_d897, 2); jmpd(0x1017_d8eb, 0x52); goto l_0x1017_d8eb; /* jmp 0x1017d8eb */
        l_0x1017_d899:
            ii(0x1017_d899, 7); cmp(memd_a32[ss, ebp - 0x10], 0xff00);  /* cmp dword [ebp-0x10], 0xff00 */
            ii(0x1017_d8a0, 2); if(jnzd(0x1017_d8b8, 0x16)) goto l_0x1017_d8b8; /* jnz 0x1017d8b8 */
            ii(0x1017_d8a2, 5); mov(eax, 0xffff);                       /* mov eax, 0xffff */
            ii(0x1017_d8a7, 5); calld(/* sys */ 0x1017_de3a, 0x58e);    /* call 0x1017de3a */
            ii(0x1017_d8ac, 10); mov(memd_a32[ds, 0x101c_0735], 0xff00); /* mov dword [0x101c0735], 0xff00 */
            ii(0x1017_d8b6, 2); jmpd(0x1017_d8cf, 0x17); goto l_0x1017_d8cf; /* jmp 0x1017d8cf */
        l_0x1017_d8b8:
            ii(0x1017_d8b8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_d8ba, 5); mov(eax, 0x12_34dc);                    /* mov eax, 0x1234dc */
            ii(0x1017_d8bf, 3); div(memd_a32[ss, ebp - 0x10]);          /* div dword [ebp-0x10] */
            ii(0x1017_d8c2, 5); calld(/* sys */ 0x1017_de3a, 0x573);    /* call 0x1017de3a */
            ii(0x1017_d8c7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1017_d8ca, 5); mov(memd_a32[ds, 0x101c_0735], eax);    /* mov [0x101c0735], eax */
        l_0x1017_d8cf:
            ii(0x1017_d8cf, 6); mov(memw_a32[ds, 0x101c_06f7], cs);     /* mov [0x101c06f7], cs */
            ii(0x1017_d8d5, 10); mov(memd_a32[ds, 0x101c_06f3], /* sys */ 0x1017_df39); /* mov dword [0x101c06f3], 0x1017df39 */
            ii(0x1017_d8df, 10); mov(memd_a32[ds, 0x101c_0775], 0x1_0000); /* mov dword [0x101c0775], 0x10000 */
            ii(0x1017_d8e9, 2); jmpd(0x1017_d8f5, 0xa); goto l_0x1017_d8f5; /* jmp 0x1017d8f5 */
        l_0x1017_d8eb:
            ii(0x1017_d8eb, 10); mov(memd_a32[ds, 0x101c_0695], 0xffff); /* mov dword [0x101c0695], 0xffff */
        l_0x1017_d8f5:
            ii(0x1017_d8f5, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1017_d8fc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1017_d8ff, 1); leaved();                               /* leave */
            ii(0x1017_d900, 1); popd(edi);                              /* pop edi */
            ii(0x1017_d901, 1); popd(esi);                              /* pop esi */
            ii(0x1017_d902, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_d903, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_d904, 1); retd(); return;                         /* ret */
        }
    }
}
