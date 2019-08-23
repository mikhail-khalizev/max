using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_c049-2c967c86")]
        public void Method_100a_c049()
        {
            ii(0x100a_c049, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_c04e, 5); call(Definitions.sys_check_available_stack_size, 0xb_9cff); /* call 0x10165d52 */
            ii(0x100a_c053, 1); push(ebx);                              /* push ebx */
            ii(0x100a_c054, 1); push(ecx);                              /* push ecx */
            ii(0x100a_c055, 1); push(esi);                              /* push esi */
            ii(0x100a_c056, 1); push(edi);                              /* push edi */
            ii(0x100a_c057, 1); push(ebp);                              /* push ebp */
            ii(0x100a_c058, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c05a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_c060, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_c063, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_c066, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100a_c068, 3); mov(esi, memd[ss, ebp - 0x4]);          /* mov esi, [ebp-0x4] */
            ii(0x100a_c06b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c06e, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_c071, 5); call(0x1007_6574, -0x3_5b02);           /* call 0x10076574 */
            ii(0x100a_c076, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100a_c079, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_c07c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c07f, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_c082, 5); call(0x1007_6574, -0x3_5b13);           /* call 0x10076574 */
            ii(0x100a_c087, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100a_c08a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_c08d, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_c090, 5); call(0x1007_6aac, -0x3_55e9);           /* call 0x10076aac */
            ii(0x100a_c095, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_c097, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c09a, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_c09d, 5); call(0x100b_7e44, 0xbda2);              /* call 0x100b7e44 */
            ii(0x100a_c0a2, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x100a_c0a4, 5); call(0x100a_bbb8, -0x4f1);              /* call 0x100abbb8 */
            ii(0x100a_c0a9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c0ab, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c0ae, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_c0b1, 5); call(0x100b_7ea0, 0xbdea);              /* call 0x100b7ea0 */
            ii(0x100a_c0b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c0b8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c0bb, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_c0be, 5); call(0x1007_6630, -0x3_5a93);           /* call 0x10076630 */
            ii(0x100a_c0c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c0c5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_c0c6, 1); pop(edi);                               /* pop edi */
            ii(0x100a_c0c7, 1); pop(esi);                               /* pop esi */
            ii(0x100a_c0c8, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_c0c9, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_c0ca, 1); ret();                                  /* ret */
        }
    }
}
