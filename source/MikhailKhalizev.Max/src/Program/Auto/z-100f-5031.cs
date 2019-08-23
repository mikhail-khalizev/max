using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_5031-7009c2cb")]
        public void Method_100f_5031()
        {
            ii(0x100f_5031, 5); push(0x108);                            /* push 0x108 */
            ii(0x100f_5036, 5); call(Definitions.sys_check_available_stack_size, 0x7_0d17); /* call 0x10165d52 */
            ii(0x100f_503b, 1); push(ebx);                              /* push ebx */
            ii(0x100f_503c, 1); push(ecx);                              /* push ecx */
            ii(0x100f_503d, 1); push(edx);                              /* push edx */
            ii(0x100f_503e, 1); push(esi);                              /* push esi */
            ii(0x100f_503f, 1); push(edi);                              /* push edi */
            ii(0x100f_5040, 1); push(ebp);                              /* push ebp */
            ii(0x100f_5041, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_5043, 6); sub(esp, 0xd4);                         /* sub esp, 0xd4 */
            ii(0x100f_5049, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_504c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_504f, 5); call(0x1007_6338, -0x7_ed1c);           /* call 0x10076338 */
            ii(0x100f_5054, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5056, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_5059, 5); call(0x1007_64b8, -0x7_eba6);           /* call 0x100764b8 */
        l_0x100f_505e:
            ii(0x100f_505e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5060, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_5063, 5); call(0x1013_ad71, 0x4_5d09);            /* call 0x1013ad71 */
            ii(0x100f_5068, 2); test(al, al);                           /* test al, al */
            ii(0x100f_506a, 6); if(jz(0x100f_5201, 0x191)) goto l_0x100f_5201; /* jz 0x100f5201 */
            ii(0x100f_5070, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_5073, 5); call(0x1007_63a0, -0x7_ecd8);           /* call 0x100763a0 */
            ii(0x100f_5078, 4); cmp(memb[ds, eax + 0x3d], 0x3);         /* cmp byte [eax+0x3d], 0x3 */
            ii(0x100f_507c, 2); if(jz(0x100f_508c, 0xe)) goto l_0x100f_508c; /* jz 0x100f508c */
            ii(0x100f_507e, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_5081, 5); call(0x1007_63a0, -0x7_ece6);           /* call 0x100763a0 */
            ii(0x100f_5086, 4); cmp(memb[ds, eax + 0x3d], 0x9);         /* cmp byte [eax+0x3d], 0x9 */
            ii(0x100f_508a, 2); if(jnz(0x100f_508e, 0x2)) goto l_0x100f_508e; /* jnz 0x100f508e */
        l_0x100f_508c:
            ii(0x100f_508c, 2); jmp(0x100f_509c, 0xe); goto l_0x100f_509c; /* jmp 0x100f509c */
        l_0x100f_508e:
            ii(0x100f_508e, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_5091, 5); call(0x1007_63a0, -0x7_ecf6);           /* call 0x100763a0 */
            ii(0x100f_5096, 4); cmp(memb[ds, eax + 0x3e], 0xe);         /* cmp byte [eax+0x3e], 0xe */
            ii(0x100f_509a, 2); if(jnz(0x100f_509e, 0x2)) goto l_0x100f_509e; /* jnz 0x100f509e */
        l_0x100f_509c:
            ii(0x100f_509c, 2); jmp(0x100f_50ac, 0xe); goto l_0x100f_50ac; /* jmp 0x100f50ac */
        l_0x100f_509e:
            ii(0x100f_509e, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_50a1, 5); call(0x1007_63a0, -0x7_ed06);           /* call 0x100763a0 */
            ii(0x100f_50a6, 4); cmp(memb[ds, eax + 0x3d], 0x5);         /* cmp byte [eax+0x3d], 0x5 */
            ii(0x100f_50aa, 2); if(jnz(0x100f_50ae, 0x2)) goto l_0x100f_50ae; /* jnz 0x100f50ae */
        l_0x100f_50ac:
            ii(0x100f_50ac, 2); jmp(0x100f_50bc, 0xe); goto l_0x100f_50bc; /* jmp 0x100f50bc */
        l_0x100f_50ae:
            ii(0x100f_50ae, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_50b1, 5); call(0x1007_63a0, -0x7_ed16);           /* call 0x100763a0 */
            ii(0x100f_50b6, 4); cmp(memb[ds, eax + 0x3d], 0x17);        /* cmp byte [eax+0x3d], 0x17 */
            ii(0x100f_50ba, 2); if(jnz(0x100f_50be, 0x2)) goto l_0x100f_50be; /* jnz 0x100f50be */
        l_0x100f_50bc:
            ii(0x100f_50bc, 2); jmp(0x100f_50cc, 0xe); goto l_0x100f_50cc; /* jmp 0x100f50cc */
        l_0x100f_50be:
            ii(0x100f_50be, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_50c1, 5); call(0x1007_63a0, -0x7_ed26);           /* call 0x100763a0 */
            ii(0x100f_50c6, 4); cmp(memb[ds, eax + 0x3d], 0x19);        /* cmp byte [eax+0x3d], 0x19 */
            ii(0x100f_50ca, 2); if(jnz(0x100f_50ce, 0x2)) goto l_0x100f_50ce; /* jnz 0x100f50ce */
        l_0x100f_50cc:
            ii(0x100f_50cc, 2); jmp(0x100f_50dc, 0xe); goto l_0x100f_50dc; /* jmp 0x100f50dc */
        l_0x100f_50ce:
            ii(0x100f_50ce, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_50d1, 5); call(0x1007_63a0, -0x7_ed36);           /* call 0x100763a0 */
            ii(0x100f_50d6, 4); cmp(memb[ds, eax + 0x3d], 0x18);        /* cmp byte [eax+0x3d], 0x18 */
            ii(0x100f_50da, 2); if(jnz(0x100f_50de, 0x2)) goto l_0x100f_50de; /* jnz 0x100f50de */
        l_0x100f_50dc:
            ii(0x100f_50dc, 2); jmp(0x100f_50ec, 0xe); goto l_0x100f_50ec; /* jmp 0x100f50ec */
        l_0x100f_50de:
            ii(0x100f_50de, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_50e1, 5); call(0x1007_63a0, -0x7_ed46);           /* call 0x100763a0 */
            ii(0x100f_50e6, 4); cmp(memb[ds, eax + 0x3d], 0x16);        /* cmp byte [eax+0x3d], 0x16 */
            ii(0x100f_50ea, 2); if(jnz(0x100f_50ee, 0x2)) goto l_0x100f_50ee; /* jnz 0x100f50ee */
        l_0x100f_50ec:
            ii(0x100f_50ec, 2); jmp(0x100f_510c, 0x1e); goto l_0x100f_510c; /* jmp 0x100f510c */
        l_0x100f_50ee:
            ii(0x100f_50ee, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_50f1, 5); call(0x1007_63a0, -0x7_ed56);           /* call 0x100763a0 */
            ii(0x100f_50f6, 4); cmp(memb[ds, eax + 0x3d], 0x2);         /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100f_50fa, 2); if(jnz(0x100f_510a, 0xe)) goto l_0x100f_510a; /* jnz 0x100f510a */
            ii(0x100f_50fc, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_50ff, 5); call(0x1007_63a0, -0x7_ed64);           /* call 0x100763a0 */
            ii(0x100f_5104, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_5108, 2); if(jnz(0x100f_510c, 0x2)) goto l_0x100f_510c; /* jnz 0x100f510c */
        l_0x100f_510a:
            ii(0x100f_510a, 2); jmp(0x100f_510e, 0x2); goto l_0x100f_510e; /* jmp 0x100f510e */
        l_0x100f_510c:
            ii(0x100f_510c, 2); jmp(0x100f_512c, 0x1e); goto l_0x100f_512c; /* jmp 0x100f512c */
        l_0x100f_510e:
            ii(0x100f_510e, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_5111, 5); call(0x1007_63a0, -0x7_ed76);           /* call 0x100763a0 */
            ii(0x100f_5116, 4); cmp(memb[ds, eax + 0x3d], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x100f_511a, 2); if(jnz(0x100f_512a, 0xe)) goto l_0x100f_512a; /* jnz 0x100f512a */
            ii(0x100f_511c, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_511f, 5); call(0x1007_63a0, -0x7_ed84);           /* call 0x100763a0 */
            ii(0x100f_5124, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_5128, 2); if(jnz(0x100f_512c, 0x2)) goto l_0x100f_512c; /* jnz 0x100f512c */
        l_0x100f_512a:
            ii(0x100f_512a, 2); jmp(0x100f_512e, 0x2); goto l_0x100f_512e; /* jmp 0x100f512e */
        l_0x100f_512c:
            ii(0x100f_512c, 2); jmp(0x100f_514c, 0x1e); goto l_0x100f_514c; /* jmp 0x100f514c */
        l_0x100f_512e:
            ii(0x100f_512e, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_5131, 5); call(0x1007_63a0, -0x7_ed96);           /* call 0x100763a0 */
            ii(0x100f_5136, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x100f_513a, 2); if(jnz(0x100f_514a, 0xe)) goto l_0x100f_514a; /* jnz 0x100f514a */
            ii(0x100f_513c, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_513f, 5); call(0x1007_63a0, -0x7_eda4);           /* call 0x100763a0 */
            ii(0x100f_5144, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_5148, 2); if(jnz(0x100f_514c, 0x2)) goto l_0x100f_514c; /* jnz 0x100f514c */
        l_0x100f_514a:
            ii(0x100f_514a, 2); jmp(0x100f_514e, 0x2); goto l_0x100f_514e; /* jmp 0x100f514e */
        l_0x100f_514c:
            ii(0x100f_514c, 2); jmp(0x100f_5160, 0x12); goto l_0x100f_5160; /* jmp 0x100f5160 */
        l_0x100f_514e:
            ii(0x100f_514e, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_5151, 5); call(0x1007_63a0, -0x7_edb6);           /* call 0x100763a0 */
            ii(0x100f_5156, 4); cmp(memb[ds, eax + 0x3e], 0);           /* cmp byte [eax+0x3e], 0x0 */
            ii(0x100f_515a, 6); if(jnz(0x100f_51f4, 0x94)) goto l_0x100f_51f4; /* jnz 0x100f51f4 */
        l_0x100f_5160:
            ii(0x100f_5160, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_5163, 5); call(0x1007_63a0, -0x7_edc8);           /* call 0x100763a0 */
            ii(0x100f_5168, 3); mov(eax, memd[ds, eax + 0x3a]);         /* mov eax, [eax+0x3a] */
            ii(0x100f_516b, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_516e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_5171, 6); push(memd[ds, eax + 0x101b_8978]);      /* push dword [eax+0x101b8978] */
            ii(0x100f_5177, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_517a, 5); call(0x1007_63a0, -0x7_eddf);           /* call 0x100763a0 */
            ii(0x100f_517f, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x100f_5182, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5185, 1); inc(eax);                               /* inc eax */
            ii(0x100f_5186, 1); push(eax);                              /* push eax */
            ii(0x100f_5187, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_518a, 5); call(0x1007_63a0, -0x7_edef);           /* call 0x100763a0 */
            ii(0x100f_518f, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x100f_5192, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5195, 1); inc(eax);                               /* inc eax */
            ii(0x100f_5196, 1); push(eax);                              /* push eax */
            ii(0x100f_5197, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_519a, 5); call(0x1007_63a0, -0x7_edff);           /* call 0x100763a0 */
            ii(0x100f_519f, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_51a2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_51a5, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_51a8, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x100f_51ae, 5); mov(eax, StringDefinitions.EndTurnDelayedBecauseSAtIIIsS); /* mov eax, 0x101a253f */
            ii(0x100f_51b3, 1); push(eax);                              /* push eax */
            ii(0x100f_51b4, 6); lea(eax, memd[ss, ebp - 0xd4]);         /* lea eax, [ebp-0xd4] */
            ii(0x100f_51ba, 1); push(eax);                              /* push eax */
            ii(0x100f_51bb, 5); call(Definitions.sys_sprintf, 0x7_0d41); /* call 0x10165f01 */
            ii(0x100f_51c0, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100f_51c3, 5); call(0x100c_aa00, -0x2_a7c8);           /* call 0x100caa00 */
            ii(0x100f_51c8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_51cd, 1); push(eax);                              /* push eax */
            ii(0x100f_51ce, 5); call(0x100c_aa20, -0x2_a7b3);           /* call 0x100caa20 */
            ii(0x100f_51d3, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_51d5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_51d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_51d9, 6); lea(eax, memd[ss, ebp - 0xd4]);         /* lea eax, [ebp-0xd4] */
            ii(0x100f_51df, 5); call(0x1011_5d23, 0x2_0b3f);            /* call 0x10115d23 */
            ii(0x100f_51e4, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x100f_51e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_51ea, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_51ed, 5); call(0x1007_5f6c, -0x7_f286);           /* call 0x10075f6c */
            ii(0x100f_51f2, 2); jmp(0x100f_521b, 0x27); goto l_0x100f_521b; /* jmp 0x100f521b */
        l_0x100f_51f4:
            ii(0x100f_51f4, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_51f7, 5); call(0x1007_6bf8, -0x7_e604);           /* call 0x10076bf8 */
            ii(0x100f_51fc, 5); jmp(0x100f_505e, -0x1a3); goto l_0x100f_505e; /* jmp 0x100f505e */
        l_0x100f_5201:
            ii(0x100f_5201, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_5205, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5207, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_520a, 5); call(0x1007_5f6c, -0x7_f2a3);           /* call 0x10075f6c */
            ii(0x100f_520f, 2); jmp(0x100f_521b, 0xa); goto l_0x100f_521b; /* jmp 0x100f521b */
        //  ii(0x100f_5211, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100f_5213, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
        //  ii(0x100f_5216, 5); call(0x1007_5f6c, -0x7_f2af);           /* call 0x10075f6c */
        l_0x100f_521b:
            ii(0x100f_521b, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100f_521e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_5220, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_5221, 1); pop(edi);                               /* pop edi */
            ii(0x100f_5222, 1); pop(esi);                               /* pop esi */
            ii(0x100f_5223, 1); pop(edx);                               /* pop edx */
            ii(0x100f_5224, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_5225, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_5226, 1); ret();                                  /* ret */
        }
    }
}
