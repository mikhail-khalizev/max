using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6942-206155af")]
        public void Method_1013_6942()
        {
            ii(0x1013_6942, 5); push(0x30);                             /* push 0x30 */
            ii(0x1013_6947, 5); call(Definitions.sys_check_available_stack_size, 0x2_f406); /* call 0x10165d52 */
            ii(0x1013_694c, 1); push(ebx);                              /* push ebx */
            ii(0x1013_694d, 1); push(ecx);                              /* push ecx */
            ii(0x1013_694e, 1); push(esi);                              /* push esi */
            ii(0x1013_694f, 1); push(edi);                              /* push edi */
            ii(0x1013_6950, 1); push(ebp);                              /* push ebp */
            ii(0x1013_6951, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6953, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_6959, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_695c, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_695f, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x1013_6966, 2); if(jz(0x1013_697c, 0x14)) goto l_0x1013_697c; /* jz 0x1013697c */
            ii(0x1013_6968, 5); mov(edx, 0x101b_6d14);                  /* mov edx, 0x101b6d14 */
            ii(0x1013_696d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_6970, 5); call(Definitions.sys_call_dtor_arr, 0x2_f643); /* call 0x10165fb8 */
            ii(0x1013_6975, 5); call(Definitions.sys_delete_arr, 0x2_f65e); /* call 0x10165fd8 */
            ii(0x1013_697a, 2); jmp(0x1013_69d8, 0x5c); goto l_0x1013_69d8; /* jmp 0x101369d8 */
        l_0x1013_697c:
            ii(0x1013_697c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_697f, 7); mov(memd[ds, eax + 19], 0x101b_6e7c);   /* mov dword [eax+0x13], 0x101b6e7c */
            ii(0x1013_6986, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_6989, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x1013_698c, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1013_698f, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_6993, 2); if(jz(0x1013_69b0, 0x1b)) goto l_0x1013_69b0; /* jz 0x101369b0 */
            ii(0x1013_6995, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_6998, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1013_699b, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1013_699e, 3); mov(ebx, memd[ds, eax + 39]);           /* mov ebx, [eax+0x27] */
            ii(0x1013_69a1, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1013_69a6, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1013_69a9, 2); call_abs(memd[ds, ebx]);                /* call dword [ebx] */
            ii(0x1013_69ab, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1013_69ae, 2); jmp(0x1013_69b7, 7); goto l_0x1013_69b7; /* jmp 0x101369b7 */
        l_0x1013_69b0:
            ii(0x1013_69b0, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
        l_0x1013_69b7:
            ii(0x1013_69b7, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_69bc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_69bf, 5); call(0x100d_6999, -0x6_002b);           /* call 0x100d6999 */
            ii(0x1013_69c4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_69c7, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x1013_69ce, 2); if(jz(0x1013_69d8, 8)) goto l_0x1013_69d8; /* jz 0x101369d8 */
            ii(0x1013_69d0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_69d3, 5); call(Definitions.sys_delete, 0x2_f58c); /* call 0x10165f64 */
        l_0x1013_69d8:
            ii(0x1013_69d8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_69db, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_69de, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_69e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_69e3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_69e4, 1); pop(edi);                               /* pop edi */
            ii(0x1013_69e5, 1); pop(esi);                               /* pop esi */
            ii(0x1013_69e6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_69e7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_69e8, 1); ret();                                  /* ret */
        }
    }
}
