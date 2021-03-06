using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0ebd-c42c05cd")]
        public void Method_100d_0ebd()
        {
            ii(0x100d_0ebd, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x100d_0ec2, 5);  call(Definitions.sys_check_available_stack_size, 0x9_4e8b);/* call 0x10165d52 */
            ii(0x100d_0ec7, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_0ec8, 1);  push(esi);                            /* push esi */
            ii(0x100d_0ec9, 1);  push(edi);                            /* push edi */
            ii(0x100d_0eca, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_0ecb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_0ecd, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x100d_0ed3, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_0ed6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_0ed9, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100d_0edc, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_0ee0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0ee3, 5);  call(0x100d_67d8, 0x58f0);            /* call 0x100d67d8 */
            ii(0x100d_0ee8, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_0eeb, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100d_0eee, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_0ef1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0ef4, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100d_0ef7, 3);  mov(memd[ds, edx + 49], eax);         /* mov [edx+0x31], eax */
            ii(0x100d_0efa, 5);  call(0x1008_b3ec, -0x4_5b13);         /* call 0x1008b3ec */
            ii(0x100d_0eff, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_0f02, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f05, 3);  add(eax, 0x3a);                       /* add eax, 0x3a */
            ii(0x100d_0f08, 5);  call(0x1008_b1e4, -0x4_5d29);         /* call 0x1008b1e4 */
            ii(0x100d_0f0d, 3);  sub(eax, 0x3a);                       /* sub eax, 0x3a */
            ii(0x100d_0f10, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_0f13, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100d_0f16, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_0f19, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f1c, 7);  mov(memd[ds, eax + 19], 0x101b_5c88); /* mov dword [eax+0x13], 0x101b5c88 */
            ii(0x100d_0f23, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f26, 7);  mov(memd[ds, eax + 66], 0);           /* mov dword [eax+0x42], 0x0 */
            ii(0x100d_0f2d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f30, 7);  mov(memd[ds, eax + 70], 0);           /* mov dword [eax+0x46], 0x0 */
            ii(0x100d_0f37, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f3a, 7);  mov(memd[ds, eax + 74], 0);           /* mov dword [eax+0x4a], 0x0 */
            ii(0x100d_0f41, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f44, 7);  mov(memd[ds, eax + 78], 0);           /* mov dword [eax+0x4e], 0x0 */
            ii(0x100d_0f4b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f4e, 7);  mov(memd[ds, eax + 82], 0);           /* mov dword [eax+0x52], 0x0 */
            ii(0x100d_0f55, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f58, 7);  mov(memd[ds, eax + 86], 0);           /* mov dword [eax+0x56], 0x0 */
            ii(0x100d_0f5f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f62, 7);  mov(memd[ds, eax + 90], 0);           /* mov dword [eax+0x5a], 0x0 */
            ii(0x100d_0f69, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f6c, 7);  mov(memd[ds, eax + 106], 0);          /* mov dword [eax+0x6a], 0x0 */
            ii(0x100d_0f73, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f76, 7);  mov(memd[ds, eax + 110], 0);          /* mov dword [eax+0x6e], 0x0 */
            ii(0x100d_0f7d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f80, 7);  mov(memd[ds, eax + 114], 0);          /* mov dword [eax+0x72], 0x0 */
            ii(0x100d_0f87, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f8a, 7);  mov(memd[ds, eax + 118], 0);          /* mov dword [eax+0x76], 0x0 */
            ii(0x100d_0f91, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f94, 7);  mov(memd[ds, eax + 122], 0);          /* mov dword [eax+0x7a], 0x0 */
            ii(0x100d_0f9b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0f9e, 7);  mov(memd[ds, eax + 126], 0);          /* mov dword [eax+0x7e], 0x0 */
            ii(0x100d_0fa5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0fa8, 10);  mov(memd[ds, eax + 130], 0);         /* mov dword [eax+0x82], 0x0 */
            ii(0x100d_0fb2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0fb5, 7);  mov(memb[ds, eax + 134], 0);          /* mov byte [eax+0x86], 0x0 */
            ii(0x100d_0fbc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0fbf, 5);  call(0x1009_c9a0, -0x3_4624);         /* call 0x1009c9a0 */
            ii(0x100d_0fc4, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_0fc6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0fc9, 4);  mov(memw[ds, eax + 56], dx);          /* mov [eax+0x38], dx */
            ii(0x100d_0fcd, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x100d_0fd4:
            ii(0x100d_0fd4, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_0fd7, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
            ii(0x100d_0fda, 1);  cwde();                               /* cwde */
            ii(0x100d_0fdb, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_0fdd, 6);  mov(edx, memd[ds, eax + 0x101b_7b76]);/* mov edx, [eax+0x101b7b76] */
            ii(0x100d_0fe3, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_0fe6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0fe9, 3);  mov(eax, memd[ds, eax + 49]);         /* mov eax, [eax+0x31] */
            ii(0x100d_0fec, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_0fef, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_0ff2, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100d_0ff4, 2);  if(jz(0x100d_1009, 0x13)) goto l_0x100d_1009;/* jz 0x100d1009 */
            ii(0x100d_0ff6, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100d_0ffa, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_0ffc, 7);  mov(ax, memw[ds, eax + 0x101b_7b78]); /* mov ax, [eax+0x101b7b78] */
            ii(0x100d_1003, 1);  inc(eax);                             /* inc eax */
            ii(0x100d_1004, 3);  add(memd[ss, ebp - 20], eax);         /* add [ebp-0x14], eax */
            ii(0x100d_1007, 2);  jmp(0x100d_0fd4, -0x35); goto l_0x100d_0fd4;/* jmp 0x100d0fd4 */
        l_0x100d_1009:
            ii(0x100d_1009, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_100c, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
            ii(0x100d_100f, 1);  cwde();                               /* cwde */
            ii(0x100d_1010, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_1012, 7);  mov(ax, memw[ds, eax + 0x101b_7b78]); /* mov ax, [eax+0x101b7b78] */
            ii(0x100d_1019, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_101c, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100d_1023, 2);  jmp(0x100d_102b, 6); goto l_0x100d_102b;/* jmp 0x100d102b */
        l_0x100d_1025:
            ii(0x100d_1025, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_1028, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
        l_0x100d_102b:
            ii(0x100d_102b, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_102e, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x100d_1032, 2);  if(jge(0x100d_1078, 0x44)) goto l_0x100d_1078;/* jge 0x100d1078 */
            ii(0x100d_1034, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100d_1038, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100d_103c, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_103e, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_1040, 6);  mov(eax, memd[ds, eax + 0x101b_7b76]);/* mov eax, [eax+0x101b7b76] */
            ii(0x100d_1046, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_1049, 5);  call(0x100c_de37, -0x3217);           /* call 0x100cde37 */
            ii(0x100d_104e, 2);  test(al, al);                         /* test al, al */
            ii(0x100d_1050, 2);  if(jz(0x100d_1076, 0x24)) goto l_0x100d_1076;/* jz 0x100d1076 */
            ii(0x100d_1052, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100d_1056, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100d_105a, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_105c, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_105e, 7);  mov(ax, memw[ds, eax + 0x101b_7b78]); /* mov ax, [eax+0x101b7b78] */
            ii(0x100d_1065, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_1068, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x100d_106b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_106e, 3);  add(eax, 0x3a);                       /* add eax, 0x3a */
            ii(0x100d_1071, 5);  call(0x1008_b2a8, -0x4_5dce);         /* call 0x1008b2a8 */
        l_0x100d_1076:
            ii(0x100d_1076, 2);  jmp(0x100d_1025, -0x53); goto l_0x100d_1025;/* jmp 0x100d1025 */
        l_0x100d_1078:
            ii(0x100d_1078, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_107d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_1080, 5);  call(0x100d_6adf, 0x5a5a);            /* call 0x100d6adf */
            ii(0x100d_1085, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100d_108a, 5);  call(0x1012_0d94, 0x4_fd05);          /* call 0x10120d94 */
            ii(0x100d_108f, 5);  call(0x100f_fc13, 0x2_eb7f);          /* call 0x100ffc13 */
            ii(0x100d_1094, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100d_1097, 3);  add(edx, 0x17);                       /* add edx, 0x17 */
            ii(0x100d_109a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_109d, 5);  call(0x100d_6a11, 0x596f);            /* call 0x100d6a11 */
            ii(0x100d_10a2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_10a5, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_10a8, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_10ab, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_10ad, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_10ae, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_10af, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_10b0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_10b1, 1);  ret();                                /* ret */
        }
    }
}
