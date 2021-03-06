using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_3fec-2c3bec8e")]
        public void Method_1011_3fec()
        {
            ii(0x1011_3fec, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1011_3ff1, 5);  call(Definitions.sys_check_available_stack_size, 0x5_1d5c);/* call 0x10165d52 */
            ii(0x1011_3ff6, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_3ff7, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_3ff8, 1);  push(edx);                            /* push edx */
            ii(0x1011_3ff9, 1);  push(esi);                            /* push esi */
            ii(0x1011_3ffa, 1);  push(edi);                            /* push edi */
            ii(0x1011_3ffb, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_3ffc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_3ffe, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1011_4004, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_4007, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_400a, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_400d, 3);  sub(eax, 0xd);                        /* sub eax, 0xd */
            ii(0x1011_4010, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_4013, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4016, 4);  cmp(memb[ds, eax + 19], 0);           /* cmp byte [eax+0x13], 0x0 */
            ii(0x1011_401a, 2);  if(jz(0x1011_4060, 0x44)) goto l_0x1011_4060;/* jz 0x10114060 */
            ii(0x1011_401c, 5);  call(0x100c_aa00, -0x4_9621);         /* call 0x100caa00 */
            ii(0x1011_4021, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_4026, 1);  push(eax);                            /* push eax */
            ii(0x1011_4027, 5);  call(0x100c_aa20, -0x4_960c);         /* call 0x100caa20 */
            ii(0x1011_402c, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1011_402e, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1011_4033, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_4035, 5);  mov(eax, StringDefinitions.TheHostHasSelectedALoadFileThatIsNotCompatibleWithTheLoadFileOnYourSystemYouWillNotBeAbleToStartThisSessionUntilTheHostSelectsAn);/* mov eax, 0x101a4820 */
            ii(0x1011_403a, 5);  call(0x1011_5d23, 0x1ce4);            /* call 0x10115d23 */
            ii(0x1011_403f, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1011_4042, 2);  add(al, 0xd);                         /* add al, 0xd */
            ii(0x1011_4044, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1011_4047, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_4049, 4);  movsx(eax, memb[ss, ebp - 12]);       /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_404d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_4050, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_4053, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1011_4056, 5);  call(0x100c_fb73, -0x4_44e8);         /* call 0x100cfb73 */
            ii(0x1011_405b, 5);  jmp(0x1011_4110, 0xb0); goto l_0x1011_4110;/* jmp 0x10114110 */
        l_0x1011_4060:
            ii(0x1011_4060, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4063, 3);  mov(al, memb[ds, eax + 17]);          /* mov al, [eax+0x11] */
            ii(0x1011_4066, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_406b, 5);  cmp(eax, 0xff);                       /* cmp eax, 0xff */
            ii(0x1011_4070, 2);  if(jz(0x1011_408b, 0x19)) goto l_0x1011_408b;/* jz 0x1011408b */
            ii(0x1011_4072, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4075, 3);  mov(al, memb[ds, eax + 17]);          /* mov al, [eax+0x11] */
            ii(0x1011_4078, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_407a, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_407d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4080, 5);  call(0x1011_3129, -0xf5c);            /* call 0x10113129 */
            ii(0x1011_4085, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4088, 3);  dec(memb[ds, eax + 15]);              /* dec byte [eax+0xf] */
        l_0x1011_408b:
            ii(0x1011_408b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_408e, 6);  add(edx, 0x21a);                      /* add edx, 0x21a */
            ii(0x1011_4094, 4);  imul(ebx, memd[ss, ebp - 8], 0x1e);   /* imul ebx, [ebp-0x8], 0x1e */
            ii(0x1011_4098, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_409b, 5);  add(eax, 0x338);                      /* add eax, 0x338 */
            ii(0x1011_40a0, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1011_40a2, 5);  call(Definitions.sys_strcpy, 0x5_1e28);/* call 0x10165ecf */
            ii(0x1011_40a7, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_40aa, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1011_40ac, 3);  add(edx, memd[ss, ebp - 4]);          /* add edx, [ebp-0x4] */
            ii(0x1011_40af, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_40b2, 4);  mov(ax, memw[ds, eax + 20]);          /* mov ax, [eax+0x14] */
            ii(0x1011_40b6, 7);  mov(memw[ds, edx + 1244], ax);        /* mov [edx+0x4dc], ax */
            ii(0x1011_40bd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_40c0, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1011_40c3, 7);  mov(memb[ds, eax + 1260], 1);         /* mov byte [eax+0x4ec], 0x1 */
            ii(0x1011_40ca, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1011_40cd, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_40d0, 3);  mov(memb[ds, edx + 17], al);          /* mov [edx+0x11], al */
            ii(0x1011_40d3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_40d6, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1011_40d8, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_40db, 6);  mov(dl, memb[ds, eax + 1252]);        /* mov dl, [eax+0x4e4] */
            ii(0x1011_40e1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_40e4, 3);  mov(memb[ds, eax + 18], dl);          /* mov [eax+0x12], dl */
            ii(0x1011_40e7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_40ea, 3);  inc(memb[ds, eax + 15]);              /* inc byte [eax+0xf] */
            ii(0x1011_40ed, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_40f0, 3);  mov(al, memb[ds, eax + 11]);          /* mov al, [eax+0xb] */
            ii(0x1011_40f3, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_40f8, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_40fa, 2);  if(jnz(0x1011_4103, 7)) goto l_0x1011_4103;/* jnz 0x10114103 */
            ii(0x1011_40fc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_40ff, 4);  mov(memb[ds, eax + 11], 1);           /* mov byte [eax+0xb], 0x1 */
        l_0x1011_4103:
            ii(0x1011_4103, 5);  call(0x1012_ab2f, 0x1_6a27);          /* call 0x1012ab2f */
            ii(0x1011_4108, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_410b, 5);  call(0x1011_390d, -0x803);            /* call 0x1011390d */
        l_0x1011_4110:
            ii(0x1011_4110, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_4112, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_4113, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_4114, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_4115, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_4116, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_4117, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_4118, 1);  ret();                                /* ret */
        }
    }
}
