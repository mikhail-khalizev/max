using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_4396-382f1857")]
        public void Method_1011_4396()
        {
            ii(0x1011_4396, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_439b, 5); call(Definitions.sys_check_available_stack_size, 0x5_19b2); /* call 0x10165d52 */
            ii(0x1011_43a0, 1); push(ebx);                              /* push ebx */
            ii(0x1011_43a1, 1); push(ecx);                              /* push ecx */
            ii(0x1011_43a2, 1); push(edx);                              /* push edx */
            ii(0x1011_43a3, 1); push(esi);                              /* push esi */
            ii(0x1011_43a4, 1); push(edi);                              /* push edi */
            ii(0x1011_43a5, 1); push(ebp);                              /* push ebp */
            ii(0x1011_43a6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_43a8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_43ae, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_43b1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_43b4, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_43b7, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_43b9, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_43bc, 7); mov(ax, memw[ds, eax + 0x324]);         /* mov ax, [eax+0x324] */
            ii(0x1011_43c3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_43c6, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_43ca, 5); call(0x1012_b10f, 0x1_6d40);            /* call 0x1012b10f */
            ii(0x1011_43cf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_43d2, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1011_43d4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_43d7, 6); mov(eax, memd[ds, eax + 0x5a5]);        /* mov eax, [eax+0x5a5] */
            ii(0x1011_43dd, 5); call(0x100d_7f6c, -0x3_c476);           /* call 0x100d7f6c */
            ii(0x1011_43e2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_43e5, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_43e7, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1011_43ea, 5); call(Definitions.sys_display_draw_0, 0x5_3095); /* call 0x10167484 */
        l_0x1011_43ef:
            ii(0x1011_43ef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_43f2, 3); mov(eax, memd[ds, eax + 0xa]);          /* mov eax, [eax+0xa] */
            ii(0x1011_43f5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_43f8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_43fa, 2); if(jnz(0x1011_441c, 0x20)) goto l_0x1011_441c; /* jnz 0x1011441c */
            ii(0x1011_43fc, 5); call(0x1012_ac94, 0x1_6893);            /* call 0x1012ac94 */
            ii(0x1011_4401, 5); call(/* sys */ 0x1016_b208, 0x5_6e02);  /* call 0x1016b208 */
            ii(0x1011_4406, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_4409, 4); cmp(memd[ss, ebp - 0xc], 0x1b);         /* cmp dword [ebp-0xc], 0x1b */
            ii(0x1011_440d, 2); if(jz(0x1011_4418, 0x9)) goto l_0x1011_4418; /* jz 0x10114418 */
            ii(0x1011_440f, 7); cmp(memd[ss, ebp - 0xc], 0x3fc);        /* cmp dword [ebp-0xc], 0x3fc */
            ii(0x1011_4416, 2); if(jnz(0x1011_441a, 0x2)) goto l_0x1011_441a; /* jnz 0x1011441a */
        l_0x1011_4418:
            ii(0x1011_4418, 2); jmp(0x1011_441c, 0x2); goto l_0x1011_441c; /* jmp 0x1011441c */
        l_0x1011_441a:
            ii(0x1011_441a, 2); jmp(0x1011_43ef, -0x2d); goto l_0x1011_43ef; /* jmp 0x101143ef */
        l_0x1011_441c:
            ii(0x1011_441c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_441f, 5); call(0x1011_390d, -0xb17);              /* call 0x1011390d */
            ii(0x1011_4424, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4427, 5); cmp(memw[ds, eax + 0xc], 0);            /* cmp word [eax+0xc], 0x0 */
            ii(0x1011_442c, 2); if(jz(0x1011_445a, 0x2c)) goto l_0x1011_445a; /* jz 0x1011445a */
            ii(0x1011_442e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_4433, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4436, 5); call(0x1011_417f, -0x2bc);              /* call 0x1011417f */
            ii(0x1011_443b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_443d, 2); if(jnz(0x1011_444e, 0xf)) goto l_0x1011_444e; /* jnz 0x1011444e */
            ii(0x1011_443f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4442, 3); mov(al, memb[ds, eax + 0x13]);          /* mov al, [eax+0x13] */
            ii(0x1011_4445, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_444a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_444c, 2); if(jz(0x1011_4450, 0x2)) goto l_0x1011_4450; /* jz 0x10114450 */
        l_0x1011_444e:
            ii(0x1011_444e, 2); jmp(0x1011_445a, 0xa); goto l_0x1011_445a; /* jmp 0x1011445a */
        l_0x1011_4450:
            ii(0x1011_4450, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_4452, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4455, 5); call(0x1011_3d56, -0x704);              /* call 0x10113d56 */
        l_0x1011_445a:
            ii(0x1011_445a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_445c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_445d, 1); pop(edi);                               /* pop edi */
            ii(0x1011_445e, 1); pop(esi);                               /* pop esi */
            ii(0x1011_445f, 1); pop(edx);                               /* pop edx */
            ii(0x1011_4460, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_4461, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_4462, 1); ret();                                  /* ret */
        }
    }
}
