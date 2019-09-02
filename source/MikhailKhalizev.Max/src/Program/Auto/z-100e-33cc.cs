using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_33cc-e093bd0e")]
        public void Method_100e_33cc()
        {
            ii(0x100e_33cc, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_33d1, 5); call(Definitions.sys_check_available_stack_size, 0x8_297c); /* call 0x10165d52 */
            ii(0x100e_33d6, 1); push(ebx);                              /* push ebx */
            ii(0x100e_33d7, 1); push(ecx);                              /* push ecx */
            ii(0x100e_33d8, 1); push(esi);                              /* push esi */
            ii(0x100e_33d9, 1); push(edi);                              /* push edi */
            ii(0x100e_33da, 1); push(ebp);                              /* push ebp */
            ii(0x100e_33db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_33dd, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_33e3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_33e6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_33e9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_33ec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_33ef, 5); call(0x100e_3020, -0x3d4);              /* call 0x100e3020 */
            ii(0x100e_33f4, 2); test(al, al);                           /* test al, al */
            ii(0x100e_33f6, 2); if(jz(0x100e_3449, 0x51)) goto l_0x100e_3449; /* jz 0x100e3449 */
            ii(0x100e_33f8, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_33fb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_33fe, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3401, 5); call(0x1007_6574, -0x6_ce92);           /* call 0x10076574 */
            ii(0x100e_3406, 5); call(0x1008_a998, -0x5_8a73);           /* call 0x1008a998 */
            ii(0x100e_340b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_340d, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x100e_3412, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3415, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3418, 5); call(0x1007_65d0, -0x6_ce4d);           /* call 0x100765d0 */
            ii(0x100e_341d, 5); call(0x1016_3053, 0x7_fc31);            /* call 0x10163053 */
            ii(0x100e_3422, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100e_3429, 2); if(jnz(0x100e_3432, 7)) goto l_0x100e_3432; /* jnz 0x100e3432 */
            ii(0x100e_342b, 5); call(0x1016_2cb8, 0x7_f888);            /* call 0x10162cb8 */
            ii(0x100e_3430, 2); jmp(0x100e_3449, 0x17); goto l_0x100e_3449; /* jmp 0x100e3449 */
        l_0x100e_3432:
            ii(0x100e_3432, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_3434, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x100e_3439, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_343c, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_343f, 5); call(0x1007_65d0, -0x6_ce74);           /* call 0x100765d0 */
            ii(0x100e_3444, 5); call(0x100e_0e24, -0x2625);             /* call 0x100e0e24 */
        l_0x100e_3449:
            ii(0x100e_3449, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_344b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_344c, 1); pop(edi);                               /* pop edi */
            ii(0x100e_344d, 1); pop(esi);                               /* pop esi */
            ii(0x100e_344e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_344f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_3450, 1); ret();                                  /* ret */
        }
    }
}
