using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4631-63b90cbb")]
        public void Method_1012_4631()
        {
            ii(0x1012_4631, 5); push(0x4c);                             /* push 0x4c */
            ii(0x1012_4636, 5); call(Definitions.sys_check_available_stack_size, 0x4_1717); /* call 0x10165d52 */
            ii(0x1012_463b, 1); push(ebx);                              /* push ebx */
            ii(0x1012_463c, 1); push(esi);                              /* push esi */
            ii(0x1012_463d, 1); push(edi);                              /* push edi */
            ii(0x1012_463e, 1); push(ebp);                              /* push ebp */
            ii(0x1012_463f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4641, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1012_4647, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_464a, 1); push(eax);                              /* push eax */
            ii(0x1012_464b, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_464e, 1); push(eax);                              /* push eax */
            ii(0x1012_464f, 5); call(0x1012_3850, -0xe04);              /* call 0x10123850 */
            ii(0x1012_4654, 3); add(esp, 8);                            /* add esp, 0x8 */
            ii(0x1012_4657, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_4659, 2); if(jz(0x1012_4677, 0x1c)) goto l_0x1012_4677; /* jz 0x10124677 */
            ii(0x1012_465b, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_465e, 1); push(eax);                              /* push eax */
            ii(0x1012_465f, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4662, 1); push(eax);                              /* push eax */
            ii(0x1012_4663, 5); call(0x1012_3d82, -0x8e6);              /* call 0x10123d82 */
            ii(0x1012_4668, 3); add(esp, 8);                            /* add esp, 0x8 */
            ii(0x1012_466b, 7); mov(memd[ss, ebp - 4], 1);              /* mov dword [ebp-0x4], 0x1 */
            ii(0x1012_4672, 5); jmp(0x1012_47a5, 0x12e); goto l_0x1012_47a5; /* jmp 0x101247a5 */
        l_0x1012_4677:
            ii(0x1012_4677, 4); cmp(memd[ss, ebp + 0x24], 0x10);        /* cmp dword [ebp+0x24], 0x10 */
            ii(0x1012_467b, 2); if(jnz(0x1012_4697, 0x1a)) goto l_0x1012_4697; /* jnz 0x10124697 */
            ii(0x1012_467d, 4); mov(memb[ss, ebp - 0x30], 0x30);        /* mov byte [ebp-0x30], 0x30 */
            ii(0x1012_4681, 4); mov(memb[ss, ebp - 0x2f], 0x78);        /* mov byte [ebp-0x2f], 0x78 */
            ii(0x1012_4685, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1012_468a, 3); lea(edx, memd[ss, ebp - 0x2e]);         /* lea edx, [ebp-0x2e] */
            ii(0x1012_468d, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_4690, 5); call(/* sys */ 0x1017_93f8, 0x5_4d63);  /* call 0x101793f8 */
            ii(0x1012_4695, 2); jmp(0x1012_46a7, 0x10); goto l_0x1012_46a7; /* jmp 0x101246a7 */
        l_0x1012_4697:
            ii(0x1012_4697, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1012_469c, 3); lea(edx, memd[ss, ebp - 0x30]);         /* lea edx, [ebp-0x30] */
            ii(0x1012_469f, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_46a2, 5); call(/* sys */ 0x1017_93f8, 0x5_4d51);  /* call 0x101793f8 */
        l_0x1012_46a7:
            ii(0x1012_46a7, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_46aa, 6); mov(eax, memd[ds, eax + 0x90]);         /* mov eax, [eax+0x90] */
            ii(0x1012_46b0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_46b3, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1012_46b6, 5); call(Definitions.sys_strlen, 0x4_d80c); /* call 0x10171ec7 */
            ii(0x1012_46bb, 3); mov(edx, memd[ss, ebp + 0x20]);         /* mov edx, [ebp+0x20] */
            ii(0x1012_46be, 3); add(edx, 4);                            /* add edx, 0x4 */
            ii(0x1012_46c1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_46c3, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1012_46c6, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_46c9, 6); mov(edx, memd[ds, eax + 0x88]);         /* mov edx, [eax+0x88] */
            ii(0x1012_46cf, 3); add(edx, memd[ss, ebp - 0xc]);          /* add edx, [ebp-0xc] */
            ii(0x1012_46d2, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_46d5, 6); cmp(edx, memd[ds, eax + 0x8c]);         /* cmp edx, [eax+0x8c] */
            ii(0x1012_46db, 2); if(jbe(0x1012_46e9, 0xc)) goto l_0x1012_46e9; /* jbe 0x101246e9 */
            ii(0x1012_46dd, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_46e4, 5); jmp(0x1012_47a5, 0xbc); goto l_0x1012_47a5; /* jmp 0x101247a5 */
        l_0x1012_46e9:
            ii(0x1012_46e9, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_46ec, 6); mov(edx, memd[ds, eax + 0x84]);         /* mov edx, [eax+0x84] */
            ii(0x1012_46f2, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_46f5, 6); add(edx, memd[ds, eax + 0x88]);         /* add edx, [eax+0x88] */
            ii(0x1012_46fb, 3); sub(edx, memd[ss, ebp - 0x10]);         /* sub edx, [ebp-0x10] */
            ii(0x1012_46fe, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1012_4700, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_4703, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_4706, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1012_4709, 5); call(/* sys */ 0x1016_6177, 0x4_1a69);  /* call 0x10166177 */
        l_0x1012_470e:
            ii(0x1012_470e, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_4711, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1012_4714, 2); if(jz(0x1012_472e, 0x18)) goto l_0x1012_472e; /* jz 0x1012472e */
            ii(0x1012_4716, 3); mov(edx, memd[ss, ebp + 0x18]);         /* mov edx, [ebp+0x18] */
            ii(0x1012_4719, 3); inc(memd[ss, ebp + 0x18]);              /* inc dword [ebp+0x18] */
            ii(0x1012_471c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_471f, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1012_4722, 2); mov(dl, memb[ds, edx]);                 /* mov dl, [edx] */
            ii(0x1012_4724, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
            ii(0x1012_4726, 3); mov(eax, memd[ss, ebp + 0x20]);         /* mov eax, [ebp+0x20] */
            ii(0x1012_4729, 3); dec(memd[ss, ebp + 0x20]);              /* dec dword [ebp+0x20] */
            ii(0x1012_472c, 2); jmp(0x1012_470e, -0x20); goto l_0x1012_470e; /* jmp 0x1012470e */
        l_0x1012_472e:
            ii(0x1012_472e, 3); dec(memd[ss, ebp + 0x20]);              /* dec dword [ebp+0x20] */
            ii(0x1012_4731, 4); cmp(memd[ss, ebp + 0x20], -1 /* 0xff */); /* cmp dword [ebp+0x20], 0xffffffff */
            ii(0x1012_4735, 2); if(jz(0x1012_4742, 0xb)) goto l_0x1012_4742; /* jz 0x10124742 */
            ii(0x1012_4737, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_473a, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1012_473d, 3); mov(memb[ds, eax], 0x20);               /* mov byte [eax], 0x20 */
            ii(0x1012_4740, 2); jmp(0x1012_472e, -0x14); goto l_0x1012_472e; /* jmp 0x1012472e */
        l_0x1012_4742:
            ii(0x1012_4742, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_4745, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1012_4748, 3); mov(memb[ds, eax], 0x3d);               /* mov byte [eax], 0x3d */
            ii(0x1012_474b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_474e, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1012_4751, 3); mov(memb[ds, eax], 0x20);               /* mov byte [eax], 0x20 */
            ii(0x1012_4754, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
        l_0x1012_475b:
            ii(0x1012_475b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_475e, 5); cmp(memb[ds, eax + ebp - 0x30], 0);     /* cmp byte [eax+ebp-0x30], 0x0 */
            ii(0x1012_4763, 2); if(jz(0x1012_4779, 0x14)) goto l_0x1012_4779; /* jz 0x10124779 */
            ii(0x1012_4765, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_4768, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_476b, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_476e, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1012_4771, 4); mov(al, memb[ds, eax + ebp - 0x30]);    /* mov al, [eax+ebp-0x30] */
            ii(0x1012_4775, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x1012_4777, 2); jmp(0x1012_475b, -0x1e); goto l_0x1012_475b; /* jmp 0x1012475b */
        l_0x1012_4779:
            ii(0x1012_4779, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_477c, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1012_477f, 3); mov(memb[ds, eax], 0xd);                /* mov byte [eax], 0xd */
            ii(0x1012_4782, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_4785, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1012_4788, 3); mov(memb[ds, eax], 0xa);                /* mov byte [eax], 0xa */
            ii(0x1012_478b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_478e, 3); mov(edx, memd[ss, ebp + 0x14]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_4791, 6); add(memd[ds, edx + 0x88], eax);         /* add [edx+0x88], eax */
            ii(0x1012_4797, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_479a, 4); or(memb[ds, eax + 1], -0x80 /* 0x80 */); /* or byte [eax+0x1], 0x80 */
            ii(0x1012_479e, 7); mov(memd[ss, ebp - 4], 1);              /* mov dword [ebp-0x4], 0x1 */
        l_0x1012_47a5:
            ii(0x1012_47a5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_47a8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_47aa, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_47ab, 1); pop(edi);                               /* pop edi */
            ii(0x1012_47ac, 1); pop(esi);                               /* pop esi */
            ii(0x1012_47ad, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_47ae, 1); ret();                                  /* ret */
        }
    }
}
