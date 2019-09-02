using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7474-7e2c0eb4")]
        public void Method_1008_7474()
        {
            ii(0x1008_7474, 5); push(0x30);                             /* push 0x30 */
            ii(0x1008_7479, 5); call(Definitions.sys_check_available_stack_size, 0xd_e8d4); /* call 0x10165d52 */
            ii(0x1008_747e, 1); push(ebx);                              /* push ebx */
            ii(0x1008_747f, 1); push(ecx);                              /* push ecx */
            ii(0x1008_7480, 1); push(esi);                              /* push esi */
            ii(0x1008_7481, 1); push(edi);                              /* push edi */
            ii(0x1008_7482, 1); push(ebp);                              /* push ebp */
            ii(0x1008_7483, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7485, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1008_748b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_748e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_7491, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7493, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_7496, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_7499, 5); call(0x1013_ad11, 0xb_3873);            /* call 0x1013ad11 */
            ii(0x1008_749e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_74a0, 2); if(jz(0x1008_74bd, 0x1b)) goto l_0x1008_74bd; /* jz 0x100874bd */
            ii(0x1008_74a2, 5); call(0x1008_a79c, 0x32f5);              /* call 0x1008a79c */
            ii(0x1008_74a7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_74a9, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_74ab, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_74ae, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_74b3, 5); call(0x100a_53ac, 0x1_def4);            /* call 0x100a53ac */
            ii(0x1008_74b8, 5); jmp(0x1008_7592, 0xd5); goto l_0x1008_7592; /* jmp 0x10087592 */
        l_0x1008_74bd:
            ii(0x1008_74bd, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_74c0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_74c3, 5); call(0x1015_27ed, 0xc_b325);            /* call 0x101527ed */
            ii(0x1008_74c8, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_74cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_74ce, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_74d1, 5); call(0x1008_ab1c, 0x3646);              /* call 0x1008ab1c */
            ii(0x1008_74d6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_74d9, 6); mov(memw[ds, eax + 0x1e], 0);           /* mov word [eax+0x1e], 0x0 */
            ii(0x1008_74df, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_74e2, 6); mov(memw[ds, eax + 0x20], 0);           /* mov word [eax+0x20], 0x0 */
            ii(0x1008_74e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_74eb, 5); cmp(memw[ds, eax + 8], 0x4b);           /* cmp word [eax+0x8], 0x4b */
            ii(0x1008_74f0, 2); if(jz(0x1008_74fc, 0xa)) goto l_0x1008_74fc; /* jz 0x100874fc */
            ii(0x1008_74f2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_74f5, 5); cmp(memw[ds, eax + 8], 0x3b);           /* cmp word [eax+0x8], 0x3b */
            ii(0x1008_74fa, 2); if(jnz(0x1008_7505, 9)) goto l_0x1008_7505; /* jnz 0x10087505 */
        l_0x1008_74fc:
            ii(0x1008_74fc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_74ff, 6); mov(memw[ds, eax + 0x1d], 0xffff);      /* mov word [eax+0x1d], 0xffff */
        l_0x1008_7505:
            ii(0x1008_7505, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_7508, 5); cmp(memw[ds, eax + 8], 0x3f);           /* cmp word [eax+0x8], 0x3f */
            ii(0x1008_750d, 2); if(jnz(0x1008_7518, 9)) goto l_0x1008_7518; /* jnz 0x10087518 */
            ii(0x1008_750f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_7512, 6); mov(memw[ds, eax + 0x1f], 0xffff);      /* mov word [eax+0x1f], 0xffff */
        l_0x1008_7518:
            ii(0x1008_7518, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_751b, 5); cmp(memw[ds, eax + 8], 0x4b);           /* cmp word [eax+0x8], 0x4b */
            ii(0x1008_7520, 2); if(jz(0x1008_752c, 0xa)) goto l_0x1008_752c; /* jz 0x1008752c */
            ii(0x1008_7522, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_7525, 5); cmp(memw[ds, eax + 8], 0x3b);           /* cmp word [eax+0x8], 0x3b */
            ii(0x1008_752a, 2); if(jnz(0x1008_752e, 2)) goto l_0x1008_752e; /* jnz 0x1008752e */
        l_0x1008_752c:
            ii(0x1008_752c, 2); jmp(0x1008_7538, 0xa); goto l_0x1008_7538; /* jmp 0x10087538 */
        l_0x1008_752e:
            ii(0x1008_752e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_7531, 5); cmp(memw[ds, eax + 8], 0x3f);           /* cmp word [eax+0x8], 0x3f */
            ii(0x1008_7536, 2); if(jnz(0x1008_7546, 0xe)) goto l_0x1008_7546; /* jnz 0x10087546 */
        l_0x1008_7538:
            ii(0x1008_7538, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_753b, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1008_753e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_7541, 3); cmp(eax, 5);                            /* cmp eax, 0x5 */
            ii(0x1008_7544, 2); if(jl(0x1008_7548, 2)) goto l_0x1008_7548; /* jl 0x10087548 */
        l_0x1008_7546:
            ii(0x1008_7546, 2); jmp(0x1008_7592, 0x4a); goto l_0x1008_7592; /* jmp 0x10087592 */
        l_0x1008_7548:
            ii(0x1008_7548, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x1008_754d, 5); call(Definitions.sys_new, 0xd_e8ae);    /* call 0x10165e00 */
            ii(0x1008_7552, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_7555, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_7558, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_755b, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1008_755f, 2); if(jz(0x1008_757f, 0x1e)) goto l_0x1008_757f; /* jz 0x1008757f */
            ii(0x1008_7561, 5); mov(ecx, 5);                            /* mov ecx, 0x5 */
            ii(0x1008_7566, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1008_7569, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_756c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_756f, 5); call(0x1008_bd0b, 0x4797);              /* call 0x1008bd0b */
            ii(0x1008_7574, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_7577, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_757a, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_757d, 2); jmp(0x1008_7585, 6); goto l_0x1008_7585; /* jmp 0x10087585 */
        l_0x1008_757f:
            ii(0x1008_757f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_7582, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1008_7585:
            ii(0x1008_7585, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1008_7588, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_758d, 5); call(0x100a_4d50, 0x1_d7be);            /* call 0x100a4d50 */
        l_0x1008_7592:
            ii(0x1008_7592, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7594, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_7595, 1); pop(edi);                               /* pop edi */
            ii(0x1008_7596, 1); pop(esi);                               /* pop esi */
            ii(0x1008_7597, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_7598, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_7599, 1); ret();                                  /* ret */
        }
    }
}
