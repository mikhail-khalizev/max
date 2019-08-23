using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_ac97-fa602183")]
        public void Method_1014_ac97()
        {
            ii(0x1014_ac97, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1014_ac9c, 5); call(Definitions.sys_check_available_stack_size, 0x1_b0b1); /* call 0x10165d52 */
            ii(0x1014_aca1, 1); push(ebx);                              /* push ebx */
            ii(0x1014_aca2, 1); push(ecx);                              /* push ecx */
            ii(0x1014_aca3, 1); push(edx);                              /* push edx */
            ii(0x1014_aca4, 1); push(esi);                              /* push esi */
            ii(0x1014_aca5, 1); push(edi);                              /* push edi */
            ii(0x1014_aca6, 1); push(ebp);                              /* push ebp */
            ii(0x1014_aca7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_aca9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_acaf, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_acb2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_acb5, 5); call(0x1014_9fa8, -0xd12);              /* call 0x10149fa8 */
            ii(0x1014_acba, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_acbd, 6); mov(eax, memd[ds, eax + 0xa1]);         /* mov eax, [eax+0xa1] */
            ii(0x1014_acc3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_acc6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_acc8, 2); if(jle(0x1014_acd3, 0x9)) goto l_0x1014_acd3; /* jle 0x1014acd3 */
            ii(0x1014_acca, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1014_acce, 5); jmp(0x1014_adbe, 0xeb); goto l_0x1014_adbe; /* jmp 0x1014adbe */
        l_0x1014_acd3:
            ii(0x1014_acd3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_acd5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_acd8, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_acdb, 5); call(0x1013_ad11, -0xffcf);             /* call 0x1013ad11 */
            ii(0x1014_ace0, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ace2, 2); if(jz(0x1014_ad52, 0x6e)) goto l_0x1014_ad52; /* jz 0x1014ad52 */
            ii(0x1014_ace4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ace7, 4); test(memb[ds, eax + 0x12], 0x20);       /* test byte [eax+0x12], 0x20 */
            ii(0x1014_aceb, 2); if(jz(0x1014_ad3b, 0x4e)) goto l_0x1014_ad3b; /* jz 0x1014ad3b */
            ii(0x1014_aced, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_acf0, 5); call(0x1007_611c, -0xd_4bd9);           /* call 0x1007611c */
            ii(0x1014_acf5, 3); lea(ebx, memd[ss, ebp - 0x10]);         /* lea ebx, [ebp-0x10] */
            ii(0x1014_acf8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_acfa, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_acfc, 5); call(0x1007_66ac, -0xd_4655);           /* call 0x100766ac */
            ii(0x1014_ad01, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ad04, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1014_ad07, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_ad0a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ad0d, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1014_ad10, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_ad13, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_ad16, 5); call(0x1007_6574, -0xd_47a7);           /* call 0x10076574 */
            ii(0x1014_ad1b, 5); call(0x1014_eb48, 0x3e28);              /* call 0x1014eb48 */
            ii(0x1014_ad20, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ad23, 5); call(0x1015_f2cc, 0x1_45a4);            /* call 0x1015f2cc */
            ii(0x1014_ad28, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1014_ad2c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ad2e, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1014_ad31, 5); call(0x1007_5f2c, -0xd_4e0a);           /* call 0x10075f2c */
            ii(0x1014_ad36, 5); jmp(0x1014_adbe, 0x83); goto l_0x1014_adbe; /* jmp 0x1014adbe */
        l_0x1014_ad3b:
            ii(0x1014_ad3b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ad3e, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1014_ad42, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ad45, 4); mov(memb[ds, eax + 0x3e], 0x1);         /* mov byte [eax+0x3e], 0x1 */
            ii(0x1014_ad49, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1014_ad4d, 5); jmp(0x1014_adbe, 0x6c); goto l_0x1014_adbe; /* jmp 0x1014adbe */
        l_0x1014_ad52:
            ii(0x1014_ad52, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ad55, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1014_ad59, 2); if(jz(0x1014_ad64, 0x9)) goto l_0x1014_ad64; /* jz 0x1014ad64 */
            ii(0x1014_ad5b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ad5e, 4); test(memb[ds, eax + 0x14], 0x1);        /* test byte [eax+0x14], 0x1 */
            ii(0x1014_ad62, 2); if(jz(0x1014_ad66, 0x2)) goto l_0x1014_ad66; /* jz 0x1014ad66 */
        l_0x1014_ad64:
            ii(0x1014_ad64, 2); jmp(0x1014_ad85, 0x1f); goto l_0x1014_ad85; /* jmp 0x1014ad85 */
        l_0x1014_ad66:
            ii(0x1014_ad66, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_ad68, 5); mov(edx, 0xe);                          /* mov edx, 0xe */
            ii(0x1014_ad6d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ad70, 5); call(0x1016_2f96, 0x1_8221);            /* call 0x10162f96 */
            ii(0x1014_ad75, 5); mov(eax, StringDefinitions.PlaneTakeoff); /* mov eax, 0x101ad2c1 */
            ii(0x1014_ad7a, 5); call(0x100a_8b4a, -0xa_2235);           /* call 0x100a8b4a */
            ii(0x1014_ad7f, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1014_ad83, 2); jmp(0x1014_adbe, 0x39); goto l_0x1014_adbe; /* jmp 0x1014adbe */
        l_0x1014_ad85:
            ii(0x1014_ad85, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ad88, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1014_ad8b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_ad90, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_ad92, 2); if(jz(0x1014_ad9e, 0xa)) goto l_0x1014_ad9e; /* jz 0x1014ad9e */
            ii(0x1014_ad94, 5); mov(eax, StringDefinitions.Moving);     /* mov eax, 0x101ad2cf */
            ii(0x1014_ad99, 5); call(0x100a_8b4a, -0xa_2254);           /* call 0x100a8b4a */
        l_0x1014_ad9e:
            ii(0x1014_ad9e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ada1, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_ada4, 5); call(0x1007_69d8, -0xd_43d1);           /* call 0x100769d8 */
            ii(0x1014_ada9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_adac, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_adaf, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1014_adb2, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_adb5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_adb8, 3); call_abs(memd[ds, ebx + 0x28]);         /* call dword [ebx+0x28] */
            ii(0x1014_adbb, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
        l_0x1014_adbe:
            ii(0x1014_adbe, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1014_adc1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_adc3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_adc4, 1); pop(edi);                               /* pop edi */
            ii(0x1014_adc5, 1); pop(esi);                               /* pop esi */
            ii(0x1014_adc6, 1); pop(edx);                               /* pop edx */
            ii(0x1014_adc7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_adc8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_adc9, 1); ret();                                  /* ret */
        }
    }
}
