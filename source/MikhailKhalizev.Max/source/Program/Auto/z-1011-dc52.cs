using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_dc52-f68b5539")]
        public void Method_1011_dc52()
        {
            ii(0x1011_dc52, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1011_dc57, 5);  call(Definitions.sys_check_available_stack_size, 0x4_80f6);/* call 0x10165d52 */
            ii(0x1011_dc5c, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_dc5d, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_dc5e, 1);  push(esi);                            /* push esi */
            ii(0x1011_dc5f, 1);  push(edi);                            /* push edi */
            ii(0x1011_dc60, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_dc61, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_dc63, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1011_dc69, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_dc6c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_dc6f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_dc72, 4);  cmp(memd[ds, eax + 22], 0);           /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_dc76, 2);  if(jz(0x1011_dca2, 0x2a)) goto l_0x1011_dca2;/* jz 0x1011dca2 */
            ii(0x1011_dc78, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_dc7b, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1011_dc7e, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_dc81, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_dc85, 2);  if(jz(0x1011_dc9b, 0x14)) goto l_0x1011_dc9b;/* jz 0x1011dc9b */
            ii(0x1011_dc87, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_dc89, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_dc8c, 5);  call(Definitions.my_dtor_d7, -0x1a4f);/* call 0x1011c242 */
            ii(0x1011_dc91, 5);  call(Definitions.sys_delete, 0x4_82ce);/* call 0x10165f64 */
            ii(0x1011_dc96, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_dc99, 2);  jmp(0x1011_dca2, 7); goto l_0x1011_dca2;/* jmp 0x1011dca2 */
        l_0x1011_dc9b:
            ii(0x1011_dc9b, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1011_dca2:
            ii(0x1011_dca2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_dca5, 4);  cmp(memd[ds, eax + 26], 0);           /* cmp dword [eax+0x1a], 0x0 */
            ii(0x1011_dca9, 2);  if(jz(0x1011_dcd5, 0x2a)) goto l_0x1011_dcd5;/* jz 0x1011dcd5 */
            ii(0x1011_dcab, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_dcae, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x1011_dcb1, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_dcb4, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1011_dcb8, 2);  if(jz(0x1011_dcce, 0x14)) goto l_0x1011_dcce;/* jz 0x1011dcce */
            ii(0x1011_dcba, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_dcbc, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_dcbf, 5);  call(Definitions.my_dtor_d7, -0x1a82);/* call 0x1011c242 */
            ii(0x1011_dcc4, 5);  call(Definitions.sys_delete, 0x4_829b);/* call 0x10165f64 */
            ii(0x1011_dcc9, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_dccc, 2);  jmp(0x1011_dcd5, 7); goto l_0x1011_dcd5;/* jmp 0x1011dcd5 */
        l_0x1011_dcce:
            ii(0x1011_dcce, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1011_dcd5:
            ii(0x1011_dcd5, 7);  cmp(memd[ds, 0x101c_5368], 0);        /* cmp dword [0x101c5368], 0x0 */
            ii(0x1011_dcdc, 2);  if(jz(0x1011_dd1b, 0x3d)) goto l_0x1011_dd1b;/* jz 0x1011dd1b */
            ii(0x1011_dcde, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_dce5, 2);  jmp(0x1011_dced, 6); goto l_0x1011_dced;/* jmp 0x1011dced */
        l_0x1011_dce7:
            ii(0x1011_dce7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_dcea, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1011_dced:
            ii(0x1011_dced, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_dcf0, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1011_dcf7, 2);  if(jge(0x1011_dd11, 0x18)) goto l_0x1011_dd11;/* jge 0x1011dd11 */
            ii(0x1011_dcf9, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1011_dcfd, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_dd00, 6);  mov(edx, memd[ds, 0x101c_5368]);      /* mov edx, [0x101c5368] */
            ii(0x1011_dd06, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_dd08, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_dd0a, 5);  call(Definitions.sys_delete, 0x4_8255);/* call 0x10165f64 */
            ii(0x1011_dd0f, 2);  jmp(0x1011_dce7, -0x2a); goto l_0x1011_dce7;/* jmp 0x1011dce7 */
        l_0x1011_dd11:
            ii(0x1011_dd11, 5);  mov(eax, memd[ds, 0x101c_5368]);      /* mov eax, [0x101c5368] */
            ii(0x1011_dd16, 5);  call(Definitions.sys_delete, 0x4_8249);/* call 0x10165f64 */
        l_0x1011_dd1b:
            ii(0x1011_dd1b, 10);  mov(memd[ds, 0x101c_5368], 0);       /* mov dword [0x101c5368], 0x0 */
            ii(0x1011_dd25, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_dd27, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_dd2a, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1011_dd2d, 5);  call(0x1012_0424, 0x26f2);            /* call 0x10120424 */
            ii(0x1011_dd32, 3);  sub(eax, 4);                          /* sub eax, 0x4 */
            ii(0x1011_dd35, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_dd38, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_dd3a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_dd3d, 5);  call(0x100b_7368, -0x6_69da);         /* call 0x100b7368 */
            ii(0x1011_dd42, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_dd45, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_dd48, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_dd4b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_dd4e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_dd50, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_dd51, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_dd52, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_dd53, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_dd54, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_dd55, 1);  ret();                                /* ret */
        }
    }
}
