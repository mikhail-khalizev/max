using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_0439-a2b508f8")]
        public void Method_100f_0439()
        {
            ii(0x100f_0439, 5); push(0x88);                             /* push 0x88 */
            ii(0x100f_043e, 5); call(Definitions.sys_check_available_stack_size, 0x7_590f); /* call 0x10165d52 */
            ii(0x100f_0443, 1); push(ebx);                              /* push ebx */
            ii(0x100f_0444, 1); push(ecx);                              /* push ecx */
            ii(0x100f_0445, 1); push(esi);                              /* push esi */
            ii(0x100f_0446, 1); push(edi);                              /* push edi */
            ii(0x100f_0447, 1); push(ebp);                              /* push ebp */
            ii(0x100f_0448, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_044a, 6); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x100f_0450, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_0453, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100f_0456, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100f_045a, 2); if(jnz(0x100f_0462, 6)) goto l_0x100f_0462; /* jnz 0x100f0462 */
            ii(0x100f_045c, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_0460, 2); jmp(0x100f_04cd, 0x6b); goto l_0x100f_04cd; /* jmp 0x100f04cd */
        l_0x100f_0462:
            ii(0x100f_0462, 5); mov(edx, 0x101c_3f64);                  /* mov edx, 0x101c3f64 */
            ii(0x100f_0467, 3); lea(eax, memd[ss, ebp - 112]);          /* lea eax, [ebp-0x70] */
            ii(0x100f_046a, 5); call(Definitions.sys_strcpy, 0x7_5a60); /* call 0x10165ecf */
            ii(0x100f_046f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100f_0472, 3); lea(eax, memd[ss, ebp - 112]);          /* lea eax, [ebp-0x70] */
            ii(0x100f_0475, 5); call(Definitions.sys_strcat, 0x7_5ab7); /* call 0x10165f31 */
            ii(0x100f_047a, 5); mov(edx, StringDefinitions.Rb12);       /* mov edx, 0x101a2246 */
            ii(0x100f_047f, 3); lea(eax, memd[ss, ebp - 112]);          /* lea eax, [ebp-0x70] */
            ii(0x100f_0482, 5); call(Definitions.my_fopen, -0x1068);    /* call 0x100ef41f */
            ii(0x100f_0487, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_0489, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_048c, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x100f_048e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_0491, 5); call(Definitions.sys_delete, 0x7_5ace); /* call 0x10165f64 */
            ii(0x100f_0496, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_0499, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x100f_049c, 2); if(jnz(0x100f_04a4, 6)) goto l_0x100f_04a4; /* jnz 0x100f04a4 */
            ii(0x100f_049e, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_04a2, 2); jmp(0x100f_04cd, 0x29); goto l_0x100f_04cd; /* jmp 0x100f04cd */
        l_0x100f_04a4:
            ii(0x100f_04a4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_04a7, 5); call(0x100f_0253, -0x259);              /* call 0x100f0253 */
            ii(0x100f_04ac, 2); test(al, al);                           /* test al, al */
            ii(0x100f_04ae, 2); if(jnz(0x100f_04c9, 0x19)) goto l_0x100f_04c9; /* jnz 0x100f04c9 */
            ii(0x100f_04b0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_04b3, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_04b5, 5); call(Definitions.sys_fclose, 0x8_1baf); /* call 0x10172069 */
            ii(0x100f_04ba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_04bd, 6); mov(memd[ds, eax], 0);                  /* mov dword [eax], 0x0 */
            ii(0x100f_04c3, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_04c7, 2); jmp(0x100f_04cd, 4); goto l_0x100f_04cd; /* jmp 0x100f04cd */
        l_0x100f_04c9:
            ii(0x100f_04c9, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
        l_0x100f_04cd:
            ii(0x100f_04cd, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100f_04d0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_04d2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_04d3, 1); pop(edi);                               /* pop edi */
            ii(0x100f_04d4, 1); pop(esi);                               /* pop esi */
            ii(0x100f_04d5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_04d6, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_04d7, 1); ret();                                  /* ret */
        }
    }
}
