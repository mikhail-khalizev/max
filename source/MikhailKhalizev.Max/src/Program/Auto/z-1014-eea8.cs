using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_eea8-55209022")]
        public void Method_1014_eea8()
        {
            ii(0x1014_eea8, 5); push(0x20);                             /* push 0x20 */
            ii(0x1014_eead, 5); call(Definitions.sys_check_available_stack_size, 0x1_6ea0); /* call 0x10165d52 */
            ii(0x1014_eeb2, 1); push(ebx);                              /* push ebx */
            ii(0x1014_eeb3, 1); push(ecx);                              /* push ecx */
            ii(0x1014_eeb4, 1); push(esi);                              /* push esi */
            ii(0x1014_eeb5, 1); push(edi);                              /* push edi */
            ii(0x1014_eeb6, 1); push(ebp);                              /* push ebp */
            ii(0x1014_eeb7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_eeb9, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1014_eebf, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_eec2, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1014_eec5, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1014_eeca, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_eecd, 5); call(0x1007_6d98, -0xd_813a);           /* call 0x10076d98 */
            ii(0x1014_eed2, 2); test(al, al);                           /* test al, al */
            ii(0x1014_eed4, 2); if(jz(0x1014_ef01, 0x2b)) goto l_0x1014_ef01; /* jz 0x1014ef01 */
            ii(0x1014_eed6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_eed9, 5); call(0x1010_094d, -0x4_e591);           /* call 0x1010094d */
            ii(0x1014_eede, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_eee1, 5); call(0x1010_19b8, -0x4_d52e);           /* call 0x101019b8 */
            ii(0x1014_eee6, 5); call(0x1010_2bf8, -0x4_c2f3);           /* call 0x10102bf8 */
            ii(0x1014_eeeb, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_eeed, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1014_eeef, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1014_eef4, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_eef7, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1014_eefc, 5); call(0x1013_d5c0, -0x1_1941);           /* call 0x1013d5c0 */
        l_0x1014_ef01:
            ii(0x1014_ef01, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef04, 4); mov(memb[ds, eax + 0x2b], 0);           /* mov byte [eax+0x2b], 0x0 */
            ii(0x1014_ef08, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef0b, 4); mov(memb[ds, eax + 0x5e], 0);           /* mov byte [eax+0x5e], 0x0 */
            ii(0x1014_ef0f, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1014_ef14, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef17, 5); call(0x1015_2605, 0x36e9);              /* call 0x10152605 */
            ii(0x1014_ef1c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef1f, 5); cmp(memw[ds, eax + 8], 0x43);           /* cmp word [eax+0x8], 0x43 */
            ii(0x1014_ef24, 2); if(jnz(0x1014_ef3b, 0x15)) goto l_0x1014_ef3b; /* jnz 0x1014ef3b */
            ii(0x1014_ef26, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef29, 3); mov(ebx, memd[ds, eax + 0x39]);         /* mov ebx, [eax+0x39] */
            ii(0x1014_ef2c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_ef2f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ef31, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef34, 5); call(0x1014_9ab7, -0x5482);             /* call 0x10149ab7 */
            ii(0x1014_ef39, 2); jmp(0x1014_ef60, 0x25); goto l_0x1014_ef60; /* jmp 0x1014ef60 */
        l_0x1014_ef3b:
            ii(0x1014_ef3b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef3e, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_ef43, 2); if(jnz(0x1014_ef60, 0x1b)) goto l_0x1014_ef60; /* jnz 0x1014ef60 */
            ii(0x1014_ef45, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef48, 3); mov(ebx, memd[ds, eax + 0x39]);         /* mov ebx, [eax+0x39] */
            ii(0x1014_ef4b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_ef4e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ef50, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef53, 5); call(0x1014_9ab7, -0x54a1);             /* call 0x10149ab7 */
            ii(0x1014_ef58, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef5b, 5); call(0x1015_c894, 0xd934);              /* call 0x1015c894 */
        l_0x1014_ef60:
            ii(0x1014_ef60, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_ef62, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1014_ef67, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_ef6a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef6d, 5); call(0x1007_6074, -0xd_8efe);           /* call 0x10076074 */
            ii(0x1014_ef72, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ef74, 2); if(jz(0x1014_efa7, 0x31)) goto l_0x1014_efa7; /* jz 0x1014efa7 */
            ii(0x1014_ef76, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1014_ef7b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_ef7e, 5); call(0x1007_6d98, -0xd_81eb);           /* call 0x10076d98 */
            ii(0x1014_ef83, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ef85, 2); if(jnz(0x1014_ef90, 9)) goto l_0x1014_ef90; /* jnz 0x1014ef90 */
            ii(0x1014_ef87, 7); cmp(memb[ds, 0x101c_3889], 0);          /* cmp byte [0x101c3889], 0x0 */
            ii(0x1014_ef8e, 2); if(jz(0x1014_ef92, 2)) goto l_0x1014_ef92; /* jz 0x1014ef92 */
        l_0x1014_ef90:
            ii(0x1014_ef90, 2); jmp(0x1014_ef9b, 9); goto l_0x1014_ef9b; /* jmp 0x1014ef9b */
        l_0x1014_ef92:
            ii(0x1014_ef92, 7); cmp(memb[ds, 0x101c_388a], 0);          /* cmp byte [0x101c388a], 0x0 */
            ii(0x1014_ef99, 2); if(jz(0x1014_efa0, 5)) goto l_0x1014_efa0; /* jz 0x1014efa0 */
        l_0x1014_ef9b:
            ii(0x1014_ef9b, 5); call(0x100f_f5c1, -0x4_f9df);           /* call 0x100ff5c1 */
        l_0x1014_efa0:
            ii(0x1014_efa0, 7); mov(memb[ds, 0x101c_391b], 1);          /* mov byte [0x101c391b], 0x1 */
        l_0x1014_efa7:
            ii(0x1014_efa7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_efaa, 5); call(0x1015_24a1, 0x34f2);              /* call 0x101524a1 */
            ii(0x1014_efaf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_efb2, 5); call(0x1015_48ba, 0x5903);              /* call 0x101548ba */
            ii(0x1014_efb7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_efba, 5); cmp(memw[ds, eax + 8], 0x38);           /* cmp word [eax+0x8], 0x38 */
            ii(0x1014_efbf, 2); if(jz(0x1014_efcb, 0xa)) goto l_0x1014_efcb; /* jz 0x1014efcb */
            ii(0x1014_efc1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_efc4, 5); cmp(memw[ds, eax + 8], 0x4a);           /* cmp word [eax+0x8], 0x4a */
            ii(0x1014_efc9, 2); if(jnz(0x1014_efd3, 8)) goto l_0x1014_efd3; /* jnz 0x1014efd3 */
        l_0x1014_efcb:
            ii(0x1014_efcb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_efce, 5); call(0x100a_92fd, -0xa_5cd6);           /* call 0x100a92fd */
        l_0x1014_efd3:
            ii(0x1014_efd3, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1014_efd7, 2); if(jz(0x1014_efe7, 0xe)) goto l_0x1014_efe7; /* jz 0x1014efe7 */
            ii(0x1014_efd9, 5); mov(eax, 3);                            /* mov eax, 0x3 */
            ii(0x1014_efde, 5); call(0x1007_5fdc, -0xd_9007);           /* call 0x10075fdc */
            ii(0x1014_efe3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_efe5, 2); if(jz(0x1014_efe9, 2)) goto l_0x1014_efe9; /* jz 0x1014efe9 */
        l_0x1014_efe7:
            ii(0x1014_efe7, 2); jmp(0x1014_f00f, 0x26); goto l_0x1014_f00f; /* jmp 0x1014f00f */
        l_0x1014_efe9:
            ii(0x1014_efe9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_efec, 4); mov(memb[ds, eax + 0x59], 1);           /* mov byte [eax+0x59], 0x1 */
            ii(0x1014_eff0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_eff3, 5); call(0x1015_c802, 0xd80a);              /* call 0x1015c802 */
            ii(0x1014_eff8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_effb, 3); mov(al, memb[ds, eax + 0x54]);          /* mov al, [eax+0x54] */
            ii(0x1014_effe, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_f003, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_f005, 2); if(jz(0x1014_f00f, 8)) goto l_0x1014_f00f; /* jz 0x1014f00f */
            ii(0x1014_f007, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_f00a, 5); call(0x100a_9e88, -0xa_5187);           /* call 0x100a9e88 */
        l_0x1014_f00f:
            ii(0x1014_f00f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_f011, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_f012, 1); pop(edi);                               /* pop edi */
            ii(0x1014_f013, 1); pop(esi);                               /* pop esi */
            ii(0x1014_f014, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_f015, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_f016, 1); ret();                                  /* ret */
        }
    }
}
