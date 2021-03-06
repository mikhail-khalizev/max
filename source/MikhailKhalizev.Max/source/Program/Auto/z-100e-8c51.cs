using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8c51-c71f9d8")]
        public void Method_100e_8c51()
        {
            ii(0x100e_8c51, 5);  push(0x34);                           /* push 0x34 */
            ii(0x100e_8c56, 5);  call(Definitions.sys_check_available_stack_size, 0x7_d0f7);/* call 0x10165d52 */
            ii(0x100e_8c5b, 1);  push(esi);                            /* push esi */
            ii(0x100e_8c5c, 1);  push(edi);                            /* push edi */
            ii(0x100e_8c5d, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_8c5e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_8c60, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100e_8c66, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8c69, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x100e_8c6c, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100e_8c6f, 3);  mov(memd[ss, ebp - 12], ecx);         /* mov [ebp-0xc], ecx */
            ii(0x100e_8c72, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_8c75, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100e_8c78, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_8c7b, 5);  call(/* sys */ 0x1016_b258, 0x8_25d8);/* call 0x1016b258 */
            ii(0x100e_8c80, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_8c84, 5);  call(Definitions.my_get_res_data_by_id_malloc, 0x4_b562);/* call 0x101341eb */
            ii(0x100e_8c89, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_8c8c, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100e_8c90, 2);  if(jnz(0x100e_8c9e, 0xc)) goto l_0x100e_8c9e;/* jnz 0x100e8c9e */
            ii(0x100e_8c92, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_8c99, 5);  jmp(0x100e_8d13, 0x75); goto l_0x100e_8d13;/* jmp 0x100e8d13 */
        l_0x100e_8c9e:
            ii(0x100e_8c9e, 5);  cmp(memw[ss, ebp - 12], 0);           /* cmp word [ebp-0xc], 0x0 */
            ii(0x100e_8ca3, 2);  if(jz(0x100e_8cad, 8)) goto l_0x100e_8cad;/* jz 0x100e8cad */
            ii(0x100e_8ca5, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_8ca8, 5);  call(0x100e_8a40, -0x26d);            /* call 0x100e8a40 */
        l_0x100e_8cad:
            ii(0x100e_8cad, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_8cb0, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_8cb3, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_8cb7, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100e_8cba, 2);  if(jnz(0x100e_8cc5, 9)) goto l_0x100e_8cc5;/* jnz 0x100e8cc5 */
            ii(0x100e_8cbc, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_8cbf, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100e_8cc2, 3);  mov(memd[ss, ebp + 20], eax);         /* mov [ebp+0x14], eax */
        l_0x100e_8cc5:
            ii(0x100e_8cc5, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100e_8cc9, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100e_8ccc, 2);  if(jnz(0x100e_8cd8, 0xa)) goto l_0x100e_8cd8;/* jnz 0x100e8cd8 */
            ii(0x100e_8cce, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_8cd1, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x100e_8cd5, 3);  mov(memd[ss, ebp + 24], eax);         /* mov [ebp+0x18], eax */
        l_0x100e_8cd8:
            ii(0x100e_8cd8, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_8cdc, 1);  push(eax);                            /* push eax */
            ii(0x100e_8cdd, 4);  movsx(ecx, memw[ss, ebp + 24]);       /* movsx ecx, word [ebp+0x18] */
            ii(0x100e_8ce1, 4);  movsx(ebx, memw[ss, ebp + 20]);       /* movsx ebx, word [ebp+0x14] */
            ii(0x100e_8ce5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_8ce8, 3);  mov(edx, memd[ds, eax + 22]);         /* mov edx, [eax+0x16] */
            ii(0x100e_8ceb, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_8cee, 5);  call(0x100e_8b24, -0x1cf);            /* call 0x100e8b24 */
            ii(0x100e_8cf3, 4);  cmp(memb[ss, ebp + 16], 0);           /* cmp byte [ebp+0x10], 0x0 */
            ii(0x100e_8cf7, 2);  if(jz(0x100e_8d04, 0xb)) goto l_0x100e_8d04;/* jz 0x100e8d04 */
            ii(0x100e_8cf9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_8cfc, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100e_8cff, 5);  call(Definitions.sys_display_draw_0, 0x7_e780);/* call 0x10167484 */
        l_0x100e_8d04:
            ii(0x100e_8d04, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_8d07, 5);  call(Definitions.sys_delete, 0x7_d258);/* call 0x10165f64 */
            ii(0x100e_8d0c, 7);  mov(memd[ss, ebp - 28], 1);           /* mov dword [ebp-0x1c], 0x1 */
        l_0x100e_8d13:
            ii(0x100e_8d13, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_8d16, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_8d18, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_8d19, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_8d1a, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_8d1b, 3);  ret(0xc);                             /* ret 0xc */
        }
    }
}
