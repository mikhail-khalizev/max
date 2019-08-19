using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_d6ba-b076c48c")]
        public void Method_1008_d6ba()
        {
            ii(0x1008_d6ba, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1008_d6bf, 5); calld(Definitions.sys_check_available_stack_size, 0xd_868e); /* call 0x10165d52 */
            ii(0x1008_d6c4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_d6c5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_d6c6, 1); pushd(edx);                             /* push edx */
            ii(0x1008_d6c7, 1); pushd(esi);                             /* push esi */
            ii(0x1008_d6c8, 1); pushd(edi);                             /* push edi */
            ii(0x1008_d6c9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_d6ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_d6cc, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_d6d2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_d6d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d6d8, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d6db, 5); calld(0x1007_6574, -0x1_716c);          /* call 0x10076574 */
            ii(0x1008_d6e0, 5); cmp(memw_a32[ds, eax + 0x8], 0x3d);     /* cmp word [eax+0x8], 0x3d */
            ii(0x1008_d6e5, 2); if(jnzd(0x1008_d6fb, 0x14)) goto l_0x1008_d6fb; /* jnz 0x1008d6fb */
            ii(0x1008_d6e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d6ea, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d6ed, 5); calld(0x1007_65d0, -0x1_7122);          /* call 0x100765d0 */
            ii(0x1008_d6f2, 5); calld(0x100a_2edb, 0x1_57e4);           /* call 0x100a2edb */
            ii(0x1008_d6f7, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d6f9, 2); if(jnzd(0x1008_d6fd, 0x2)) goto l_0x1008_d6fd; /* jnz 0x1008d6fd */
        l_0x1008_d6fb:
            ii(0x1008_d6fb, 2); jmpd(0x1008_d714, 0x17); goto l_0x1008_d714; /* jmp 0x1008d714 */
        l_0x1008_d6fd:
            ii(0x1008_d6fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d700, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d703, 5); calld(0x1007_6574, -0x1_7194);          /* call 0x10076574 */
            ii(0x1008_d708, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1008_d70b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_d710, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_d712, 2); if(jled(0x1008_d71d, 0x9)) goto l_0x1008_d71d; /* jle 0x1008d71d */
        l_0x1008_d714:
            ii(0x1008_d714, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_d718, 5); jmpd(0x1008_d8f5, 0x1d8); goto l_0x1008_d8f5; /* jmp 0x1008d8f5 */
        l_0x1008_d71d:
            ii(0x1008_d71d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d720, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d723, 5); calld(0x1007_6574, -0x1_71b4);          /* call 0x10076574 */
            ii(0x1008_d728, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1008_d72c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d72f, 4); cmp(dx, memw_a32[ds, eax + 0x21]);      /* cmp dx, [eax+0x21] */
            ii(0x1008_d733, 2); if(jnzd(0x1008_d74d, 0x18)) goto l_0x1008_d74d; /* jnz 0x1008d74d */
            ii(0x1008_d735, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d738, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d73b, 5); calld(0x1007_6574, -0x1_71cc);          /* call 0x10076574 */
            ii(0x1008_d740, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1008_d744, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d747, 4); cmp(dx, memw_a32[ds, eax + 0x23]);      /* cmp dx, [eax+0x23] */
            ii(0x1008_d74b, 2); if(jzd(0x1008_d74f, 0x2)) goto l_0x1008_d74f; /* jz 0x1008d74f */
        l_0x1008_d74d:
            ii(0x1008_d74d, 2); jmpd(0x1008_d758, 0x9); goto l_0x1008_d758; /* jmp 0x1008d758 */
        l_0x1008_d74f:
            ii(0x1008_d74f, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_d753, 5); jmpd(0x1008_d8f5, 0x19d); goto l_0x1008_d8f5; /* jmp 0x1008d8f5 */
        l_0x1008_d758:
            ii(0x1008_d758, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1008_d75d, 5); calld(0x1007_5fdc, -0x1_7786);          /* call 0x10075fdc */
            ii(0x1008_d762, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1008_d765, 2); if(jged(0x1008_d77d, 0x16)) goto l_0x1008_d77d; /* jge 0x1008d77d */
            ii(0x1008_d767, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d76a, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d76d, 5); calld(0x1007_6574, -0x1_71fe);          /* call 0x10076574 */
            ii(0x1008_d772, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x1008_d775, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_d778, 3); cmp(eax, 0x1a);                         /* cmp eax, 0x1a */
            ii(0x1008_d77b, 2); if(jld(0x1008_d77f, 0x2)) goto l_0x1008_d77f; /* jl 0x1008d77f */
        l_0x1008_d77d:
            ii(0x1008_d77d, 2); jmpd(0x1008_d788, 0x9); goto l_0x1008_d788; /* jmp 0x1008d788 */
        l_0x1008_d77f:
            ii(0x1008_d77f, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_d783, 5); jmpd(0x1008_d8f5, 0x16d); goto l_0x1008_d8f5; /* jmp 0x1008d8f5 */
        l_0x1008_d788:
            ii(0x1008_d788, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_d78a, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1008_d78f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_d791, 2); if(jnzd(0x1008_d7a8, 0x15)) goto l_0x1008_d7a8; /* jnz 0x1008d7a8 */
            ii(0x1008_d793, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d796, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_d799, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_d79c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d79e, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x1008_d7a4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_d7a6, 2); if(jnzd(0x1008_d7aa, 0x2)) goto l_0x1008_d7aa; /* jnz 0x1008d7aa */
        l_0x1008_d7a8:
            ii(0x1008_d7a8, 2); jmpd(0x1008_d7b3, 0x9); goto l_0x1008_d7b3; /* jmp 0x1008d7b3 */
        l_0x1008_d7aa:
            ii(0x1008_d7aa, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_d7ae, 5); jmpd(0x1008_d8f5, 0x142); goto l_0x1008_d8f5; /* jmp 0x1008d8f5 */
        l_0x1008_d7b3:
            ii(0x1008_d7b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d7b6, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d7b9, 5); calld(0x1007_6574, -0x1_724a);          /* call 0x10076574 */
            ii(0x1008_d7be, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x1008_d7c1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_d7c4, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1008_d7c7, 2); if(jged(0x1008_d7d2, 0x9)) goto l_0x1008_d7d2; /* jge 0x1008d7d2 */
            ii(0x1008_d7c9, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_d7cd, 5); jmpd(0x1008_d8f5, 0x123); goto l_0x1008_d8f5; /* jmp 0x1008d8f5 */
        l_0x1008_d7d2:
            ii(0x1008_d7d2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1008_d7d7, 1); pushd(eax);                             /* push eax */
            ii(0x1008_d7d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d7db, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d7de, 5); calld(0x1007_6574, -0x1_726f);          /* call 0x10076574 */
            ii(0x1008_d7e3, 3); mov(ecx, memd_a32[ds, eax + 0x1a]);     /* mov ecx, [eax+0x1a] */
            ii(0x1008_d7e6, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1008_d7e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d7ec, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d7ef, 5); calld(0x1007_6574, -0x1_7280);          /* call 0x10076574 */
            ii(0x1008_d7f4, 3); mov(ebx, memd_a32[ds, eax + 0x18]);     /* mov ebx, [eax+0x18] */
            ii(0x1008_d7f7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_d7fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d7fd, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x1008_d800, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_d803, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1008_d808, 5); calld(0x1007_02b9, -0x1_d554);          /* call 0x100702b9 */
            ii(0x1008_d80d, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1008_d810, 2); if(jnzd(0x1008_d81b, 0x9)) goto l_0x1008_d81b; /* jnz 0x1008d81b */
            ii(0x1008_d812, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_d816, 5); jmpd(0x1008_d8f5, 0xda); goto l_0x1008_d8f5; /* jmp 0x1008d8f5 */
        l_0x1008_d81b:
            ii(0x1008_d81b, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1008_d81e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d821, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d824, 5); calld(0x1007_6574, -0x1_72b5);          /* call 0x10076574 */
            ii(0x1008_d829, 5); calld(0x1015_0a5f, 0xc_3231);           /* call 0x10150a5f */
            ii(0x1008_d82e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_d831, 5); calld(0x1009_caf8, 0xf2c2);             /* call 0x1009caf8 */
            ii(0x1008_d836, 7); mov(memd_a32[ss, ebp - 0xc], 0x15);     /* mov dword [ebp-0xc], 0x15 */
            ii(0x1008_d83d, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x1008_d840, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_d843, 5); calld(0x1008_b2a8, -0x25a0);            /* call 0x1008b2a8 */
            ii(0x1008_d848, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_d84d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d850, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d853, 5); calld(0x1007_6574, -0x1_72e4);          /* call 0x10076574 */
            ii(0x1008_d858, 5); calld(0x1009_c970, 0xf113);             /* call 0x1009c970 */
            ii(0x1008_d85d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d860, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d863, 5); calld(0x1007_6574, -0x1_72f4);          /* call 0x10076574 */
            ii(0x1008_d868, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d86a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d86d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d870, 5); calld(0x1007_6574, -0x1_7301);          /* call 0x10076574 */
            ii(0x1008_d875, 4); mov(dx, memw_a32[ds, edx + 0x1a]);      /* mov dx, [edx+0x1a] */
            ii(0x1008_d879, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1008_d87d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d880, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d883, 5); calld(0x1007_6574, -0x1_7314);          /* call 0x10076574 */
            ii(0x1008_d888, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d88a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d88d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d890, 5); calld(0x1007_6574, -0x1_7321);          /* call 0x10076574 */
            ii(0x1008_d895, 4); mov(dx, memw_a32[ds, edx + 0x1c]);      /* mov dx, [edx+0x1c] */
            ii(0x1008_d899, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1008_d89d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d89f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d8a2, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d8a5, 5); calld(0x1007_6574, -0x1_7336);          /* call 0x10076574 */
            ii(0x1008_d8aa, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1008_d8ad, 5); calld(0x1007_6a34, -0x1_6e7e);          /* call 0x10076a34 */
            ii(0x1008_d8b2, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1008_d8b9, 2); if(jzd(0x1008_d8cb, 0x10)) goto l_0x1008_d8cb; /* jz 0x1008d8cb */
            ii(0x1008_d8bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d8be, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d8c1, 5); calld(0x1007_65d0, -0x1_72f6);          /* call 0x100765d0 */
            ii(0x1008_d8c6, 5); calld(0x1012_ae8d, 0x9_d5c2);           /* call 0x1012ae8d */
        l_0x1008_d8cb:
            ii(0x1008_d8cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d8ce, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d8d1, 5); calld(0x1007_6574, -0x1_7362);          /* call 0x10076574 */
            ii(0x1008_d8d6, 5); calld(0x1015_2387, 0xc_4aac);           /* call 0x10152387 */
            ii(0x1008_d8db, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_d8df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d8e1, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_d8e4, 5); calld(0x1008_8b04, -0x4de5);            /* call 0x10088b04 */
            ii(0x1008_d8e9, 2); jmpd(0x1008_d8f5, 0xa); goto l_0x1008_d8f5; /* jmp 0x1008d8f5 */
        //  ii(0x1008_d8eb, 10); Недостижимый код.
        l_0x1008_d8f5:
            ii(0x1008_d8f5, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_d8f8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_d8fa, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_d8fb, 1); popd(edi);                              /* pop edi */
            ii(0x1008_d8fc, 1); popd(esi);                              /* pop esi */
            ii(0x1008_d8fd, 1); popd(edx);                              /* pop edx */
            ii(0x1008_d8fe, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_d8ff, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_d900, 1); retd(); return;                         /* ret */
        }
    }
}
