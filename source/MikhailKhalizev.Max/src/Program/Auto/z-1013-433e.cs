using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_433e-7346f698")]
        public void Method_1013_433e()
        {
            ii(0x1013_433e, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_4343, 5); call(Definitions.sys_check_available_stack_size, 0x3_1a0a); /* call 0x10165d52 */
            ii(0x1013_4348, 1); push(ebx);                              /* push ebx */
            ii(0x1013_4349, 1); push(ecx);                              /* push ecx */
            ii(0x1013_434a, 1); push(edx);                              /* push edx */
            ii(0x1013_434b, 1); push(esi);                              /* push esi */
            ii(0x1013_434c, 1); push(edi);                              /* push edi */
            ii(0x1013_434d, 1); push(ebp);                              /* push ebp */
            ii(0x1013_434e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_4350, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_4356, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_4359, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_435d, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1013_4360, 2); if(jnz(0x1013_436b, 9)) goto l_0x1013_436b; /* jnz 0x1013436b */
            ii(0x1013_4362, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_4369, 2); jmp(0x1013_43a7, 0x3c); goto l_0x1013_43a7; /* jmp 0x101343a7 */
        l_0x1013_436b:
            ii(0x1013_436b, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_436f, 3); imul(edx, eax, 7);                      /* imul edx, eax, 0x7 */
            ii(0x1013_4372, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_4377, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4379, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1013_437c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_437f, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1013_4383, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1013_4386, 2); if(jnz(0x1013_4391, 9)) goto l_0x1013_4391; /* jnz 0x10134391 */
            ii(0x1013_4388, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_438f, 2); jmp(0x1013_43a7, 0x16); goto l_0x1013_43a7; /* jmp 0x101343a7 */
        l_0x1013_4391:
            ii(0x1013_4391, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1013_4395, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1013_4398, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_439a, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta]); /* mov eax, [0x101c70f0] */
            ii(0x1013_439f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_43a1, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1013_43a4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1013_43a7:
            ii(0x1013_43a7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_43aa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_43ac, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_43ad, 1); pop(edi);                               /* pop edi */
            ii(0x1013_43ae, 1); pop(esi);                               /* pop esi */
            ii(0x1013_43af, 1); pop(edx);                               /* pop edx */
            ii(0x1013_43b0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_43b1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_43b2, 1); ret();                                  /* ret */
        }
    }
}
