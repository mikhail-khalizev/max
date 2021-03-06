using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_edcd-ef43b28b")]
        public void Method_100c_edcd()
        {
            ii(0x100c_edcd, 5);  push(0x64);                           /* push 0x64 */
            ii(0x100c_edd2, 5);  call(Definitions.sys_check_available_stack_size, 0x9_6f7b);/* call 0x10165d52 */
            ii(0x100c_edd7, 1);  push(esi);                            /* push esi */
            ii(0x100c_edd8, 1);  push(edi);                            /* push edi */
            ii(0x100c_edd9, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_edda, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_eddc, 6);  sub(esp, 0x48);                       /* sub esp, 0x48 */
            ii(0x100c_ede2, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_ede5, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100c_ede8, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100c_edeb, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100c_edee, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_edf1, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100c_edf5, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_edf8, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x100c_edfb, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_edfe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ee01, 4);  mov(ax, memw[ds, eax + 12]);          /* mov ax, [eax+0xc] */
            ii(0x100c_ee05, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_ee08, 4);  sub(ax, memw[ds, edx + 4]);           /* sub ax, [edx+0x4] */
            ii(0x100c_ee0c, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_ee0f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ee12, 5);  call(0x100c_e71f, -0x6f8);            /* call 0x100ce71f */
            ii(0x100c_ee17, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ee1a, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x100c_ee1d, 5);  call(0x100d_4e8c, 0x606a);            /* call 0x100d4e8c */
            ii(0x100c_ee22, 3);  mov(memd[ss, ebp - 42], eax);         /* mov [ebp-0x2a], eax */
            ii(0x100c_ee25, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ee28, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x100c_ee2b, 5);  call(0x100d_4f58, 0x6128);            /* call 0x100d4f58 */
            ii(0x100c_ee30, 4);  mov(memw[ss, ebp - 48], ax);          /* mov [ebp-0x30], ax */
            ii(0x100c_ee34, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x100c_ee3a, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100c_ee3e, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x100c_ee40, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_ee42, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_ee45, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100c_ee47, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100c_ee49, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_ee4c, 3);  add(eax, memd[ds, edx + 4]);          /* add eax, [edx+0x4] */
            ii(0x100c_ee4f, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_ee52, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_ee55, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_ee58, 5);  call(0x100d_4d78, 0x5f1b);            /* call 0x100d4d78 */
            ii(0x100c_ee5d, 1);  push(eax);                            /* push eax */
            ii(0x100c_ee5e, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100c_ee63, 1);  push(eax);                            /* push eax */
            ii(0x100c_ee64, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_ee68, 1);  push(eax);                            /* push eax */
            ii(0x100c_ee69, 4);  movsx(ecx, memw[ss, ebp - 20]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x100c_ee6d, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100c_ee70, 3);  movsx(ebx, memw[ds, ebx]);            /* movsx ebx, word [ebx] */
            ii(0x100c_ee73, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100c_ee76, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x100c_ee79, 5);  call(0x100e_a99a, 0x1_bb1c);          /* call 0x100ea99a */
            ii(0x100c_ee7e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ee81, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100c_ee84, 5);  call(0x100d_4e8c, 0x6003);            /* call 0x100d4e8c */
            ii(0x100c_ee89, 3);  mov(memd[ss, ebp - 42], eax);         /* mov [ebp-0x2a], eax */
            ii(0x100c_ee8c, 3);  mov(edx, memd[ss, ebp + 16]);         /* mov edx, [ebp+0x10] */
            ii(0x100c_ee8f, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_ee92, 5);  call(0x100d_4d78, 0x5ee1);            /* call 0x100d4d78 */
            ii(0x100c_ee97, 1);  push(eax);                            /* push eax */
            ii(0x100c_ee98, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100c_ee9d, 1);  push(eax);                            /* push eax */
            ii(0x100c_ee9e, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_eea2, 1);  push(eax);                            /* push eax */
            ii(0x100c_eea3, 4);  movsx(ecx, memw[ss, ebp - 20]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x100c_eea7, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100c_eeaa, 3);  movsx(ebx, memw[ds, ebx]);            /* movsx ebx, word [ebx] */
            ii(0x100c_eead, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100c_eeb0, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x100c_eeb3, 5);  call(0x100e_a99a, 0x1_bae2);          /* call 0x100ea99a */
            ii(0x100c_eeb8, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_eebb, 4);  cmp(memd[ds, eax + 20], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x100c_eebf, 2);  if(jz(0x100c_ef0a, 0x49)) goto l_0x100c_ef0a;/* jz 0x100cef0a */
            ii(0x100c_eec1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_eec4, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100c_eec7, 5);  call(0x100d_4e8c, 0x5fc0);            /* call 0x100d4e8c */
            ii(0x100c_eecc, 3);  mov(memd[ss, ebp - 42], eax);         /* mov [ebp-0x2a], eax */
            ii(0x100c_eecf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_eed2, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100c_eed5, 5);  call(0x100d_4f58, 0x607e);            /* call 0x100d4f58 */
            ii(0x100c_eeda, 4);  mov(memw[ss, ebp - 48], ax);          /* mov [ebp-0x30], ax */
            ii(0x100c_eede, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x100c_eee1, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x100c_eee4, 5);  call(0x100d_4d78, 0x5e8f);            /* call 0x100d4d78 */
            ii(0x100c_eee9, 1);  push(eax);                            /* push eax */
            ii(0x100c_eeea, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100c_eeef, 1);  push(eax);                            /* push eax */
            ii(0x100c_eef0, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_eef4, 1);  push(eax);                            /* push eax */
            ii(0x100c_eef5, 4);  movsx(ecx, memw[ss, ebp - 20]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x100c_eef9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_eefc, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x100c_eeff, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100c_ef02, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x100c_ef05, 5);  call(0x100e_a99a, 0x1_ba90);          /* call 0x100ea99a */
        l_0x100c_ef0a:
            ii(0x100c_ef0a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ef0d, 4);  cmp(memd[ds, eax + 24], 0);           /* cmp dword [eax+0x18], 0x0 */
            ii(0x100c_ef11, 2);  if(jz(0x100c_ef5c, 0x49)) goto l_0x100c_ef5c;/* jz 0x100cef5c */
            ii(0x100c_ef13, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ef16, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x100c_ef19, 5);  call(0x100d_4e8c, 0x5f6e);            /* call 0x100d4e8c */
            ii(0x100c_ef1e, 3);  mov(memd[ss, ebp - 42], eax);         /* mov [ebp-0x2a], eax */
            ii(0x100c_ef21, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_ef24, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x100c_ef27, 5);  call(0x100d_4f58, 0x602c);            /* call 0x100d4f58 */
            ii(0x100c_ef2c, 4);  mov(memw[ss, ebp - 48], ax);          /* mov [ebp-0x30], ax */
            ii(0x100c_ef30, 3);  mov(edx, memd[ss, ebp + 24]);         /* mov edx, [ebp+0x18] */
            ii(0x100c_ef33, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x100c_ef36, 5);  call(0x100d_4d78, 0x5e3d);            /* call 0x100d4d78 */
            ii(0x100c_ef3b, 1);  push(eax);                            /* push eax */
            ii(0x100c_ef3c, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100c_ef41, 1);  push(eax);                            /* push eax */
            ii(0x100c_ef42, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_ef46, 1);  push(eax);                            /* push eax */
            ii(0x100c_ef47, 4);  movsx(ecx, memw[ss, ebp - 20]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x100c_ef4b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ef4e, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x100c_ef51, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100c_ef54, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x100c_ef57, 5);  call(0x100e_a99a, 0x1_ba3e);          /* call 0x100ea99a */
        l_0x100c_ef5c:
            ii(0x100c_ef5c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_ef5e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_ef5f, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_ef60, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_ef61, 3);  ret(0xc);                             /* ret 0xc */
        }
    }
}
