using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ee06-7a83fccb")]
        public void Method_100a_ee06()
        {
            ii(0x100a_ee06, 5); push(0x50);                             /* push 0x50 */
            ii(0x100a_ee0b, 5); call(Definitions.sys_check_available_stack_size, 0xb_6f42); /* call 0x10165d52 */
            ii(0x100a_ee10, 1); push(ebx);                              /* push ebx */
            ii(0x100a_ee11, 1); push(ecx);                              /* push ecx */
            ii(0x100a_ee12, 1); push(edx);                              /* push edx */
            ii(0x100a_ee13, 1); push(esi);                              /* push esi */
            ii(0x100a_ee14, 1); push(edi);                              /* push edi */
            ii(0x100a_ee15, 1); push(ebp);                              /* push ebp */
            ii(0x100a_ee16, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ee18, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100a_ee1e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_ee21, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_ee24, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ee27, 5); call(0x1007_6574, -0x3_88b8);           /* call 0x10076574 */
            ii(0x100a_ee2c, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100a_ee2f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_ee32, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_ee35, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ee38, 5); call(0x1007_6574, -0x3_88c9);           /* call 0x10076574 */
            ii(0x100a_ee3d, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100a_ee40, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_ee43, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100a_ee46, 5); call(0x1007_6aac, -0x3_839f);           /* call 0x10076aac */
            ii(0x100a_ee4b, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100a_ee4e, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_8363); /* call 0x10076af0 */
            ii(0x100a_ee53, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x100a_ee5a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_ee5d, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ee60, 5); call(Definitions.my_3_get_count, -0x2_39e5); /* call 0x1008b480 */
            ii(0x100a_ee65, 1); cwde();                                 /* cwde */
            ii(0x100a_ee66, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_ee68, 6); if(jz(0x100a_f00f, 0x1a1)) goto l_0x100a_f00f; /* jz 0x100af00f */
            ii(0x100a_ee6e, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100a_ee75, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ee77, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_ee7a, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ee7d, 5); call(0x100a_aa28, -0x445a);             /* call 0x100aaa28 */
            ii(0x100a_ee82, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_ee84, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_ee87, 5); call(0x1007_5e64, -0x3_9028);           /* call 0x10075e64 */
            ii(0x100a_ee8c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_ee8e, 3); lea(edx, memd[ss, ebp - 0x2c]);         /* lea edx, [ebp-0x2c] */
            ii(0x100a_ee91, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100a_ee94, 5); call(0x1007_5e64, -0x3_9035);           /* call 0x10075e64 */
            ii(0x100a_ee99, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_ee9b, 5); call(0x100a_5fca, -0x8ed6);             /* call 0x100a5fca */
            ii(0x100a_eea0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_eea3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_eea5, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_eea8, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_eeaa, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100a_eeac, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_eeaf, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_eeb2, 4); cmp(memb[ds, edx + 0x19], 0);           /* cmp byte [edx+0x19], 0x0 */
            ii(0x100a_eeb6, 2); if(jle(0x100a_eef1, 0x39)) goto l_0x100a_eef1; /* jle 0x100aeef1 */
            ii(0x100a_eeb8, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100a_eebd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_eec0, 3); mov(ebx, memd[ds, eax + 0x16]);         /* mov ebx, [eax+0x16] */
            ii(0x100a_eec3, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x100a_eec6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_eec9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_eecc, 5); call(0x1007_65d0, -0x3_8901);           /* call 0x100765d0 */
            ii(0x100a_eed1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_eed3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_eed6, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x100a_eed9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_eedc, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x100a_eee2, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100a_eee7, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100a_eee9, 5); call(0x100c_1fd4, 0x1_30e6);            /* call 0x100c1fd4 */
            ii(0x100a_eeee, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x100a_eef1:
            ii(0x100a_eef1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_eef4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_eef7, 5); call(0x1007_6574, -0x3_8988);           /* call 0x10076574 */
            ii(0x100a_eefc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_eefe, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_ef00, 3); mov(al, memb[ds, edx + 0x4d]);          /* mov al, [edx+0x4d] */
            ii(0x100a_ef03, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_ef06, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_ef09, 4); cmp(memb[ds, edx + 0x19], 3);           /* cmp byte [edx+0x19], 0x3 */
            ii(0x100a_ef0d, 2); if(jnz(0x100a_ef16, 7)) goto l_0x100a_ef16; /* jnz 0x100aef16 */
            ii(0x100a_ef0f, 7); mov(memd[ss, ebp - 0x18], 1);           /* mov dword [ebp-0x18], 0x1 */
        l_0x100a_ef16:
            ii(0x100a_ef16, 7); mov(memd[ss, ebp - 0x10], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x100a_ef1d, 2); jmp(0x100a_ef25, 6); goto l_0x100a_ef25; /* jmp 0x100aef25 */
        l_0x100a_ef1f:
            ii(0x100a_ef1f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_ef22, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100a_ef25:
            ii(0x100a_ef25, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_ef28, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ef2b, 5); call(Definitions.my_3_get_count, -0x2_3ab0); /* call 0x1008b480 */
            ii(0x100a_ef30, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100a_ef34, 6); if(jle(0x100a_efd9, 0x9f)) goto l_0x100a_efd9; /* jle 0x100aefd9 */
            ii(0x100a_ef3a, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100a_ef3e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_ef41, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ef44, 5); call(0x100a_aa28, -0x4521);             /* call 0x100aaa28 */
            ii(0x100a_ef49, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_ef4b, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100a_ef4e, 5); call(0x1008_8b44, -0x2_640f);           /* call 0x10088b44 */
            ii(0x100a_ef53, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100a_ef57, 2); if(jz(0x100a_ef76, 0x1d)) goto l_0x100a_ef76; /* jz 0x100aef76 */
            ii(0x100a_ef59, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100a_ef5d, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100a_ef60, 3); add(eax, memd[ss, ebp - 0x24]);         /* add eax, [ebp-0x24] */
            ii(0x100a_ef63, 4); movsx(edx, memw[ss, ebp - 0x26]);       /* movsx edx, word [ebp-0x26] */
            ii(0x100a_ef67, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100a_ef69, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100a_ef6b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_ef6d, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100a_ef70, 4); cmp(ax, memw[ss, ebp - 0x18]);          /* cmp ax, [ebp-0x18] */
            ii(0x100a_ef74, 2); if(jge(0x100a_ef78, 2)) goto l_0x100a_ef78; /* jge 0x100aef78 */
        l_0x100a_ef76:
            ii(0x100a_ef76, 2); jmp(0x100a_ef91, 0x19); goto l_0x100a_ef91; /* jmp 0x100aef91 */
        l_0x100a_ef78:
            ii(0x100a_ef78, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_ef7b, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ef7e, 5); call(0x1009_cb94, -0x1_23ef);           /* call 0x1009cb94 */
            ii(0x100a_ef83, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_ef86, 6); mov(memw[ds, eax + 0x26], 0xffff);      /* mov word [eax+0x26], 0xffff */
            ii(0x100a_ef8c, 5); jmp(0x100a_f00f, 0x7e); goto l_0x100a_f00f; /* jmp 0x100af00f */
        l_0x100a_ef91:
            ii(0x100a_ef91, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x100a_ef94, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100a_ef97, 5); call(0x1007_5e64, -0x3_9138);           /* call 0x10075e64 */
            ii(0x100a_ef9c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_ef9e, 3); lea(edx, memd[ss, ebp - 0x2c]);         /* lea edx, [ebp-0x2c] */
            ii(0x100a_efa1, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100a_efa4, 5); call(0x1007_5e64, -0x3_9145);           /* call 0x10075e64 */
            ii(0x100a_efa9, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_efab, 5); call(0x100a_5fca, -0x8fe6);             /* call 0x100a5fca */
            ii(0x100a_efb0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_efb3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_efb5, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_efb8, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_efba, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100a_efbc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_efbf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_efc2, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x100a_efc6, 2); if(jg(0x100a_efd4, 0xc)) goto l_0x100a_efd4; /* jg 0x100aefd4 */
            ii(0x100a_efc8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_efcb, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_efce, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_efd1, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x100a_efd4:
            ii(0x100a_efd4, 5); jmp(0x100a_ef1f, -0xba); goto l_0x100a_ef1f; /* jmp 0x100aef1f */
        l_0x100a_efd9:
            ii(0x100a_efd9, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100a_efdd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_efdf, 2); if(jnz(0x100a_eff0, 0xf)) goto l_0x100a_eff0; /* jnz 0x100aeff0 */
            ii(0x100a_efe1, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100a_efe5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_efe8, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_efeb, 5); call(0x100c_db14, 0x1_eb24);            /* call 0x100cdb14 */
        l_0x100a_eff0:
            ii(0x100a_eff0, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_eff3, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100a_eff6:
            ii(0x100a_eff6, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
            ii(0x100a_eff9, 5); cmp(memw[ss, ebp - 0x10], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100a_effe, 2); if(jz(0x100a_f00f, 0xf)) goto l_0x100a_f00f; /* jz 0x100af00f */
            ii(0x100a_f000, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f002, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_f005, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_f008, 5); call(0x100c_db14, 0x1_eb07);            /* call 0x100cdb14 */
            ii(0x100a_f00d, 2); jmp(0x100a_eff6, -0x19); goto l_0x100a_eff6; /* jmp 0x100aeff6 */
        l_0x100a_f00f:
            ii(0x100a_f00f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_f011, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_f012, 1); pop(edi);                               /* pop edi */
            ii(0x100a_f013, 1); pop(esi);                               /* pop esi */
            ii(0x100a_f014, 1); pop(edx);                               /* pop edx */
            ii(0x100a_f015, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_f016, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_f017, 1); ret();                                  /* ret */
        }
    }
}
