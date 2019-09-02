using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3794-43725ca1")]
        public void Method_100a_3794()
        {
            ii(0x100a_3794, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_3799, 5); call(Definitions.sys_check_available_stack_size, 0xc_25b4); /* call 0x10165d52 */
            ii(0x100a_379e, 1); push(ebx);                              /* push ebx */
            ii(0x100a_379f, 1); push(ecx);                              /* push ecx */
            ii(0x100a_37a0, 1); push(esi);                              /* push esi */
            ii(0x100a_37a1, 1); push(edi);                              /* push edi */
            ii(0x100a_37a2, 1); push(ebp);                              /* push ebp */
            ii(0x100a_37a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_37a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_37ab, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_37ae, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_37b1, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100a_37b8, 2); if(jz(0x100a_37ce, 0x14)) goto l_0x100a_37ce; /* jz 0x100a37ce */
            ii(0x100a_37ba, 5); mov(edx, 0x101b_4d58);                  /* mov edx, 0x101b4d58 */
            ii(0x100a_37bf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_37c2, 5); call(Definitions.sys_call_dtor_arr, 0xc_27f1); /* call 0x10165fb8 */
            ii(0x100a_37c7, 5); call(Definitions.sys_delete_arr, 0xc_280c); /* call 0x10165fd8 */
            ii(0x100a_37cc, 2); jmp(0x100a_380c, 0x3e); goto l_0x100a_380c; /* jmp 0x100a380c */
        l_0x100a_37ce:
            ii(0x100a_37ce, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_37d1, 7); mov(memd[ds, eax + 2], 0x101b_4f34);    /* mov dword [eax+0x2], 0x101b4f34 */
            ii(0x100a_37d8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_37da, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_37dd, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100a_37e0, 5); call(0x1008_8b7c, -0x1_ac69);           /* call 0x10088b7c */
            ii(0x100a_37e5, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x100a_37e8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_37eb, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100a_37f0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_37f3, 5); call(0x100a_36c9, -0x12f);              /* call 0x100a36c9 */
            ii(0x100a_37f8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_37fb, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_3802, 2); if(jz(0x100a_380c, 8)) goto l_0x100a_380c; /* jz 0x100a380c */
            ii(0x100a_3804, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_3807, 5); call(Definitions.sys_delete, 0xc_2758); /* call 0x10165f64 */
        l_0x100a_380c:
            ii(0x100a_380c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_380f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_3812, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_3815, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3817, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_3818, 1); pop(edi);                               /* pop edi */
            ii(0x100a_3819, 1); pop(esi);                               /* pop esi */
            ii(0x100a_381a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_381b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_381c, 1); ret();                                  /* ret */
        }
    }
}
