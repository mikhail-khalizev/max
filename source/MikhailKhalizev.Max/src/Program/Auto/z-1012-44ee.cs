using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_44ee-67690305")]
        public void Method_1012_44ee()
        {
            ii(0x1012_44ee, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_44f3, 5); call(Definitions.sys_check_available_stack_size, 0x4_185a); /* call 0x10165d52 */
            ii(0x1012_44f8, 1); push(ebx);                              /* push ebx */
            ii(0x1012_44f9, 1); push(esi);                              /* push esi */
            ii(0x1012_44fa, 1); push(edi);                              /* push edi */
            ii(0x1012_44fb, 1); push(ebp);                              /* push ebp */
            ii(0x1012_44fc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_44fe, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_4504, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_4507, 1); push(eax);                              /* push eax */
            ii(0x1012_4508, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_450b, 1); push(eax);                              /* push eax */
            ii(0x1012_450c, 5); call(0x1012_3850, -0xcc1);              /* call 0x10123850 */
            ii(0x1012_4511, 3); add(esp, 8);                            /* add esp, 0x8 */
            ii(0x1012_4514, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_4516, 2); if(jz(0x1012_4534, 0x1c)) goto l_0x1012_4534; /* jz 0x10124534 */
            ii(0x1012_4518, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_451b, 1); push(eax);                              /* push eax */
            ii(0x1012_451c, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_451f, 1); push(eax);                              /* push eax */
            ii(0x1012_4520, 5); call(0x1012_3f33, -0x5f2);              /* call 0x10123f33 */
            ii(0x1012_4525, 3); add(esp, 8);                            /* add esp, 0x8 */
            ii(0x1012_4528, 7); mov(memd[ss, ebp - 0xc], 1);            /* mov dword [ebp-0xc], 0x1 */
            ii(0x1012_452f, 5); jmp(0x1012_4627, 0xf3); goto l_0x1012_4627; /* jmp 0x10124627 */
        l_0x1012_4534:
            ii(0x1012_4534, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4537, 6); mov(eax, memd[ds, eax + 0x90]);         /* mov eax, [eax+0x90] */
            ii(0x1012_453d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_4540, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_4543, 5); call(Definitions.sys_strlen, 0x4_d97f); /* call 0x10171ec7 */
            ii(0x1012_4548, 3); mov(edx, memd[ss, ebp + 0x20]);         /* mov edx, [ebp+0x20] */
            ii(0x1012_454b, 3); add(edx, 4);                            /* add edx, 0x4 */
            ii(0x1012_454e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_4550, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_4553, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4556, 6); mov(edx, memd[ds, eax + 0x88]);         /* mov edx, [eax+0x88] */
            ii(0x1012_455c, 3); add(edx, memd[ss, ebp - 4]);            /* add edx, [ebp-0x4] */
            ii(0x1012_455f, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4562, 6); cmp(edx, memd[ds, eax + 0x8c]);         /* cmp edx, [eax+0x8c] */
            ii(0x1012_4568, 2); if(jbe(0x1012_4576, 0xc)) goto l_0x1012_4576; /* jbe 0x10124576 */
            ii(0x1012_456a, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_4571, 5); jmp(0x1012_4627, 0xb1); goto l_0x1012_4627; /* jmp 0x10124627 */
        l_0x1012_4576:
            ii(0x1012_4576, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4579, 6); mov(edx, memd[ds, eax + 0x84]);         /* mov edx, [eax+0x84] */
            ii(0x1012_457f, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4582, 6); add(edx, memd[ds, eax + 0x88]);         /* add edx, [eax+0x88] */
            ii(0x1012_4588, 3); sub(edx, memd[ss, ebp - 8]);            /* sub edx, [ebp-0x8] */
            ii(0x1012_458b, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1012_458d, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1012_4590, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_4593, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1012_4596, 5); call(/* sys */ 0x1016_6177, 0x4_1bdc);  /* call 0x10166177 */
        l_0x1012_459b:
            ii(0x1012_459b, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_459e, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1012_45a1, 2); if(jz(0x1012_45bb, 0x18)) goto l_0x1012_45bb; /* jz 0x101245bb */
            ii(0x1012_45a3, 3); mov(edx, memd[ss, ebp + 0x18]);         /* mov edx, [ebp+0x18] */
            ii(0x1012_45a6, 3); inc(memd[ss, ebp + 0x18]);              /* inc dword [ebp+0x18] */
            ii(0x1012_45a9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_45ac, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_45af, 2); mov(dl, memb[ds, edx]);                 /* mov dl, [edx] */
            ii(0x1012_45b1, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
            ii(0x1012_45b3, 3); mov(eax, memd[ss, ebp + 0x20]);         /* mov eax, [ebp+0x20] */
            ii(0x1012_45b6, 3); dec(memd[ss, ebp + 0x20]);              /* dec dword [ebp+0x20] */
            ii(0x1012_45b9, 2); jmp(0x1012_459b, -0x20); goto l_0x1012_459b; /* jmp 0x1012459b */
        l_0x1012_45bb:
            ii(0x1012_45bb, 3); dec(memd[ss, ebp + 0x20]);              /* dec dword [ebp+0x20] */
            ii(0x1012_45be, 4); cmp(memd[ss, ebp + 0x20], -1 /* 0xff */); /* cmp dword [ebp+0x20], 0xffffffff */
            ii(0x1012_45c2, 2); if(jz(0x1012_45cf, 0xb)) goto l_0x1012_45cf; /* jz 0x101245cf */
            ii(0x1012_45c4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_45c7, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_45ca, 3); mov(memb[ds, eax], 0x20);               /* mov byte [eax], 0x20 */
            ii(0x1012_45cd, 2); jmp(0x1012_45bb, -0x14); goto l_0x1012_45bb; /* jmp 0x101245bb */
        l_0x1012_45cf:
            ii(0x1012_45cf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_45d2, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_45d5, 3); mov(memb[ds, eax], 0x3d);               /* mov byte [eax], 0x3d */
            ii(0x1012_45d8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_45db, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_45de, 3); mov(memb[ds, eax], 0x20);               /* mov byte [eax], 0x20 */
        l_0x1012_45e1:
            ii(0x1012_45e1, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_45e4, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1012_45e7, 2); if(jz(0x1012_45fb, 0x12)) goto l_0x1012_45fb; /* jz 0x101245fb */
            ii(0x1012_45e9, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_45ec, 3); inc(memd[ss, ebp + 0x1c]);              /* inc dword [ebp+0x1c] */
            ii(0x1012_45ef, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1012_45f2, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_45f5, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_45f7, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x1012_45f9, 2); jmp(0x1012_45e1, -0x1a); goto l_0x1012_45e1; /* jmp 0x101245e1 */
        l_0x1012_45fb:
            ii(0x1012_45fb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_45fe, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_4601, 3); mov(memb[ds, eax], 0xd);                /* mov byte [eax], 0xd */
            ii(0x1012_4604, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_4607, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_460a, 3); mov(memb[ds, eax], 0xa);                /* mov byte [eax], 0xa */
            ii(0x1012_460d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_4610, 3); mov(edx, memd[ss, ebp + 0x14]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_4613, 6); add(memd[ds, edx + 0x88], eax);         /* add [edx+0x88], eax */
            ii(0x1012_4619, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_461c, 4); or(memb[ds, eax + 1], -0x80 /* 0x80 */); /* or byte [eax+0x1], 0x80 */
            ii(0x1012_4620, 7); mov(memd[ss, ebp - 0xc], 1);            /* mov dword [ebp-0xc], 0x1 */
        l_0x1012_4627:
            ii(0x1012_4627, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_462a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_462c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_462d, 1); pop(edi);                               /* pop edi */
            ii(0x1012_462e, 1); pop(esi);                               /* pop esi */
            ii(0x1012_462f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_4630, 1); ret();                                  /* ret */
        }
    }
}
