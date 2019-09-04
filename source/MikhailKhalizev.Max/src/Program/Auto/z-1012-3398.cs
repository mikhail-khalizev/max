using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_3398-f8382299")]
        public void Method_1012_3398()
        {
            ii(0x1012_3398, 5); push(0x18);                             /* push 0x18 */
            ii(0x1012_339d, 5); call(Definitions.sys_check_available_stack_size, 0x4_29b0); /* call 0x10165d52 */
            ii(0x1012_33a2, 1); push(ebx);                              /* push ebx */
            ii(0x1012_33a3, 1); push(esi);                              /* push esi */
            ii(0x1012_33a4, 1); push(edi);                              /* push edi */
            ii(0x1012_33a5, 1); push(ebp);                              /* push ebp */
            ii(0x1012_33a6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_33a8, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1012_33ae, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_33b1, 4); mov(memb[ds, eax + 4], 0);              /* mov byte [eax+0x4], 0x0 */
            ii(0x1012_33b5, 4); movsx(eax, memw[ss, ebp + 24]);         /* movsx eax, word [ebp+0x18] */
            ii(0x1012_33b9, 5); call(0x1013_433e, 0x1_0f80);            /* call 0x1013433e */
            ii(0x1012_33be, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_33c0, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_33c3, 6); mov(memd[ds, eax + 136], edx);          /* mov [eax+0x88], edx */
            ii(0x1012_33c9, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_33cc, 6); mov(edx, memd[ds, eax + 136]);          /* mov edx, [eax+0x88] */
            ii(0x1012_33d2, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_33d5, 6); mov(memd[ds, eax + 140], edx);          /* mov [eax+0x8c], edx */
            ii(0x1012_33db, 4); movsx(eax, memw[ss, ebp + 24]);         /* movsx eax, word [ebp+0x18] */
            ii(0x1012_33df, 5); call(Definitions.my_get_res_data_by_id_malloc, 0x1_0e07); /* call 0x101341eb */
            ii(0x1012_33e4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_33e6, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_33e9, 6); mov(memd[ds, eax + 132], edx);          /* mov [eax+0x84], edx */
            ii(0x1012_33ef, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_33f2, 7); cmp(memd[ds, eax + 132], 0);            /* cmp dword [eax+0x84], 0x0 */
            ii(0x1012_33f9, 2); if(jnz(0x1012_3404, 9)) goto l_0x1012_3404; /* jnz 0x10123404 */
            ii(0x1012_33fb, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_3402, 2); jmp(0x1012_3465, 0x61); goto l_0x1012_3465; /* jmp 0x10123465 */
        l_0x1012_3404:
            ii(0x1012_3404, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3407, 6); mov(edx, memd[ds, eax + 132]);          /* mov edx, [eax+0x84] */
            ii(0x1012_340d, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3410, 6); mov(memd[ds, eax + 144], edx);          /* mov [eax+0x90], edx */
            ii(0x1012_3416, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3419, 10); mov(memd[ds, eax + 148], 0);           /* mov dword [eax+0x94], 0x0 */
            ii(0x1012_3423, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3426, 10); mov(memd[ds, eax + 160], 0);           /* mov dword [eax+0xa0], 0x0 */
            ii(0x1012_3430, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3433, 10); mov(memd[ds, eax + 164], 0);           /* mov dword [eax+0xa4], 0x0 */
            ii(0x1012_343d, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3440, 10); mov(memd[ds, eax + 156], 0);           /* mov dword [eax+0x9c], 0x0 */
            ii(0x1012_344a, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_344d, 10); mov(memd[ds, eax + 168], 0);           /* mov dword [eax+0xa8], 0x0 */
            ii(0x1012_3457, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_345a, 4); and(memb[ds, eax + 1], 0x7f);           /* and byte [eax+0x1], 0x7f */
            ii(0x1012_345e, 7); mov(memd[ss, ebp - 4], 1);              /* mov dword [ebp-0x4], 0x1 */
        l_0x1012_3465:
            ii(0x1012_3465, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_3468, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_346a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_346b, 1); pop(edi);                               /* pop edi */
            ii(0x1012_346c, 1); pop(esi);                               /* pop esi */
            ii(0x1012_346d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_346e, 1); ret();                                  /* ret */
        }
    }
}
