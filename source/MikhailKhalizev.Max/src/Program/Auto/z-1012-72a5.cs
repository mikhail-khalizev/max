using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_72a5-448125dc")]
        public void Method_1012_72a5()
        {
            ii(0x1012_72a5, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1012_72aa, 5);  call(Definitions.sys_check_available_stack_size, 0x3_eaa3);/* call 0x10165d52 */
            ii(0x1012_72af, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_72b0, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_72b1, 1);  push(edx);                            /* push edx */
            ii(0x1012_72b2, 1);  push(esi);                            /* push esi */
            ii(0x1012_72b3, 1);  push(edi);                            /* push edi */
            ii(0x1012_72b4, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_72b5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_72b7, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1012_72bd, 5);  mov(eax, memd[ds, 0x101c_59cc]);      /* mov eax, [0x101c59cc] */
            ii(0x1012_72c2, 3);  mov(al, memb[ds, eax + 17]);          /* mov al, [eax+0x11] */
            ii(0x1012_72c5, 5);  mov(memb[ds, 0x101c_37da], al);       /* mov [0x101c37da], al */
            ii(0x1012_72ca, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1012_72cf, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_72d1, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1012_72d6, 6);  mov(eax, memd[ds, eax + 0x101b_873d]);/* mov eax, [eax+0x101b873d] */
            ii(0x1012_72dc, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1012_72df, 5);  call(0x100c_aafc, -0x5_c7e8);         /* call 0x100caafc */
            ii(0x1012_72e4, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_72e6, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1012_72eb, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1012_72f1, 7);  mov(memb[ds, eax + 0x101c_a490], 1);  /* mov byte [eax+0x101ca490], 0x1 */
            ii(0x1012_72f8, 5);  mov(eax, memd[ds, 0x101c_59cc]);      /* mov eax, [0x101c59cc] */
            ii(0x1012_72fd, 6);  lea(ebx, memd[ds, eax + 538]);        /* lea ebx, [eax+0x21a] */
            ii(0x1012_7303, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x1012_7308, 5);  mov(eax, 0x101c_39c8);                /* mov eax, 0x101c39c8 */
            ii(0x1012_730d, 5);  call(0x1010_6205, -0x2_110d);         /* call 0x10106205 */
            ii(0x1012_7312, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x1012_7317, 5);  call(0x1010_7757, -0x1_fbc5);         /* call 0x10107757 */
            ii(0x1012_731c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_731e, 6);  mov(dl, memb[ds, 0x101c_37da]);       /* mov dl, [0x101c37da] */
            ii(0x1012_7324, 3);  imul(edx, edx, 6);                    /* imul edx, edx, 0x6 */
            ii(0x1012_7327, 5);  mov(ecx, 0x101c_4090);                /* mov ecx, 0x101c4090 */
            ii(0x1012_732c, 2);  add(ecx, edx);                        /* add ecx, edx */
            ii(0x1012_732e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_7330, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1012_7332, 5);  call(Definitions.sys_memcpy, 0x3_eb14);/* call 0x10165e4b */
            ii(0x1012_7337, 5);  mov(eax, 0x33);                       /* mov eax, 0x33 */
            ii(0x1012_733c, 5);  call(0x1007_5fdc, -0xb_1365);         /* call 0x10075fdc */
            ii(0x1012_7341, 3);  mov(memb[ss, ebp - 4], al);           /* mov [ebp-0x4], al */
            ii(0x1012_7344, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_7346, 3);  mov(dl, memb[ss, ebp - 4]);           /* mov dl, [ebp-0x4] */
            ii(0x1012_7349, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1012_734e, 2);  add(al, 0x6b);                        /* add al, 0x6b */
            ii(0x1012_7350, 3);  movsx(eax, al);                       /* movsx eax, al */
            ii(0x1012_7353, 5);  call(0x100c_aafc, -0x5_c85c);         /* call 0x100caafc */
            ii(0x1012_7358, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_735a, 6);  mov(dl, memb[ds, 0x101c_37da]);       /* mov dl, [0x101c37da] */
            ii(0x1012_7360, 6);  imul(edx, edx, 0x247);                /* imul edx, edx, 0x247 */
            ii(0x1012_7366, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_7369, 6);  mov(memb[ds, edx + 0x101c_a4ef], al); /* mov [edx+0x101ca4ef], al */
            ii(0x1012_736f, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_7376, 4);  mov(memb[ss, ebp - 4], 4);            /* mov byte [ebp-0x4], 0x4 */
        l_0x1012_737a:
            ii(0x1012_737a, 3);  dec(memb[ss, ebp - 4]);               /* dec byte [ebp-0x4] */
            ii(0x1012_737d, 4);  cmp(memb[ss, ebp - 4], -1 /* 0xff */);/* cmp byte [ebp-0x4], 0xff */
            ii(0x1012_7381, 6);  if(jz(0x1012_7475, 0xee)) goto l_0x1012_7475;/* jz 0x10127475 */
            ii(0x1012_7387, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_7389, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_738c, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1012_738e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_7390, 5);  mov(eax, memd[ds, 0x101c_59cc]);      /* mov eax, [0x101c59cc] */
            ii(0x1012_7395, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_7397, 6);  mov(eax, memd[ds, eax + 1242]);       /* mov eax, [eax+0x4da] */
            ii(0x1012_739d, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_73a0, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1012_73a3, 6);  if(jle(0x1012_7425, 0x7c)) goto l_0x1012_7425;/* jle 0x10127425 */
            ii(0x1012_73a9, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_73ab, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_73ae, 3);  imul(eax, eax, 0x1e);                 /* imul eax, eax, 0x1e */
            ii(0x1012_73b1, 6);  mov(ebx, memd[ds, 0x101c_59cc]);      /* mov ebx, [0x101c59cc] */
            ii(0x1012_73b7, 6);  add(ebx, 0x338);                      /* add ebx, 0x338 */
            ii(0x1012_73bd, 2);  add(ebx, eax);                        /* add ebx, eax */
            ii(0x1012_73bf, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_73c2, 2);  add(al, 0x63);                        /* add al, 0x63 */
            ii(0x1012_73c4, 3);  movsx(edx, al);                       /* movsx edx, al */
            ii(0x1012_73c7, 5);  mov(eax, 0x101c_39c8);                /* mov eax, 0x101c39c8 */
            ii(0x1012_73cc, 5);  call(0x1010_6205, -0x2_11cc);         /* call 0x10106205 */
            ii(0x1012_73d1, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_73d3, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_73d6, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1012_73d8, 6);  mov(edx, memd[ds, 0x101c_59cc]);      /* mov edx, [0x101c59cc] */
            ii(0x1012_73de, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_73e0, 6);  mov(edx, memd[ds, 0x101c_59cc]);      /* mov edx, [0x101c59cc] */
            ii(0x1012_73e6, 7);  mov(ax, memw[ds, eax + 1244]);        /* mov ax, [eax+0x4dc] */
            ii(0x1012_73ed, 4);  cmp(ax, memw[ds, edx + 20]);          /* cmp ax, [edx+0x14] */
            ii(0x1012_73f1, 2);  if(jz(0x1012_7423, 0x30)) goto l_0x1012_7423;/* jz 0x10127423 */
            ii(0x1012_73f3, 5);  mov(edx, 3);                          /* mov edx, 0x3 */
            ii(0x1012_73f8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_73fa, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_73fd, 6);  mov(eax, memd[ds, eax + 0x101b_873d]);/* mov eax, [eax+0x101b873d] */
            ii(0x1012_7403, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1012_7406, 5);  call(0x100c_aafc, -0x5_c90f);         /* call 0x100caafc */
            ii(0x1012_740b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_740d, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_7410, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1012_7416, 7);  mov(memb[ds, eax + 0x101c_a490], 3);  /* mov byte [eax+0x101ca490], 0x3 */
            ii(0x1012_741d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_7420, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1012_7423:
            ii(0x1012_7423, 2);  jmp(0x1012_744c, 0x27); goto l_0x1012_744c;/* jmp 0x1012744c */
        l_0x1012_7425:
            ii(0x1012_7425, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_7427, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_7429, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_742c, 6);  mov(eax, memd[ds, eax + 0x101b_873d]);/* mov eax, [eax+0x101b873d] */
            ii(0x1012_7432, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1012_7435, 5);  call(0x100c_aafc, -0x5_c93e);         /* call 0x100caafc */
            ii(0x1012_743a, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_743c, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_743f, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1012_7445, 7);  mov(memb[ds, eax + 0x101c_a490], 0);  /* mov byte [eax+0x101ca490], 0x0 */
        l_0x1012_744c:
            ii(0x1012_744c, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_744e, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_7451, 7);  mov(memb[ds, eax + 0x101c_40b0], 0);  /* mov byte [eax+0x101c40b0], 0x0 */
            ii(0x1012_7458, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_745a, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_745d, 7);  mov(memb[ds, eax + 0x101c_40b4], 0);  /* mov byte [eax+0x101c40b4], 0x0 */
            ii(0x1012_7464, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_7466, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_7469, 7);  mov(memb[ds, eax + 0x101c_40b8], 0);  /* mov byte [eax+0x101c40b8], 0x0 */
            ii(0x1012_7470, 5);  jmp(0x1012_737a, -0xfb); goto l_0x1012_737a;/* jmp 0x1012737a */
        l_0x1012_7475:
            ii(0x1012_7475, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1012_7478, 5);  mov(memb[ds, 0x101c_59b8], al);       /* mov [0x101c59b8], al */
            ii(0x1012_747d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_7480, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_7483, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_7486, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_7488, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_7489, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_748a, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_748b, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_748c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_748d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_748e, 1);  ret();                                /* ret */
        }
    }
}
