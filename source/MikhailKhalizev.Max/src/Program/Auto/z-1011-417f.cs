using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_417f-4bb1f389")]
        public void Method_1011_417f()
        {
            ii(0x1011_417f, 5); push(0xe0);                             /* push 0xe0 */
            ii(0x1011_4184, 5); call(Definitions.sys_check_available_stack_size, 0x5_1bc9); /* call 0x10165d52 */
            ii(0x1011_4189, 1); push(ebx);                              /* push ebx */
            ii(0x1011_418a, 1); push(ecx);                              /* push ecx */
            ii(0x1011_418b, 1); push(esi);                              /* push esi */
            ii(0x1011_418c, 1); push(edi);                              /* push edi */
            ii(0x1011_418d, 1); push(ebp);                              /* push ebp */
            ii(0x1011_418e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_4190, 6); sub(esp, 0xc4);                         /* sub esp, 0xc4 */
            ii(0x1011_4196, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_4199, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1011_419c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_419f, 7); cmp(memb[ds, eax + 1311], 0);           /* cmp byte [eax+0x51f], 0x0 */
            ii(0x1011_41a6, 6); if(jz(0x1011_4362, 0x1b6)) goto l_0x1011_4362; /* jz 0x10114362 */
            ii(0x1011_41ac, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_41b0, 2); if(jnz(0x1011_41c2, 0x10)) goto l_0x1011_41c2; /* jnz 0x101141c2 */
            ii(0x1011_41b2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_41b5, 7); cmp(memb[ds, eax + 1310], 0);           /* cmp byte [eax+0x51e], 0x0 */
            ii(0x1011_41bc, 6); if(jz(0x1011_4360, 0x19e)) goto l_0x1011_4360; /* jz 0x10114360 */
        l_0x1011_41c2:
            ii(0x1011_41c2, 5); mov(edx, 4);                            /* mov edx, 0x4 */
            ii(0x1011_41c7, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_41cc, 5); call(0x100c_aafc, -0x4_96d5);           /* call 0x100caafc */
            ii(0x1011_41d1, 5); call(0x1011_5398, 0x11c2);              /* call 0x10115398 */
            ii(0x1011_41d6, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_41d8, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1011_41da, 6); lea(ebx, memd[ss, ebp - 184]);          /* lea ebx, [ebp-0xb8] */
            ii(0x1011_41e0, 5); mov(edx, 4);                            /* mov edx, 0x4 */
            ii(0x1011_41e5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_41e8, 6); mov(al, memb[ds, eax + 1432]);          /* mov al, [eax+0x598] */
            ii(0x1011_41ee, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_41f0, 1); cwde();                                 /* cwde */
            ii(0x1011_41f1, 5); call(0x1013_9ade, 0x2_58e8);            /* call 0x10139ade */
            ii(0x1011_41f6, 3); mov(eax, memd[ss, ebp - 18]);           /* mov eax, [ebp-0x12] */
            ii(0x1011_41f9, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_41fc, 6); cmp(eax, memd[ds, edx + 1433]);         /* cmp eax, [edx+0x599] */
            ii(0x1011_4202, 2); if(jz(0x1011_4238, 0x34)) goto l_0x1011_4238; /* jz 0x10114238 */
            ii(0x1011_4204, 5); mov(edx, 9);                            /* mov edx, 0x9 */
            ii(0x1011_4209, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_420e, 5); call(0x100c_aafc, -0x4_9717);           /* call 0x100caafc */
            ii(0x1011_4213, 5); call(0x1011_5398, 0x1180);              /* call 0x10115398 */
            ii(0x1011_4218, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_421a, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1011_421c, 6); lea(ebx, memd[ss, ebp - 184]);          /* lea ebx, [ebp-0xb8] */
            ii(0x1011_4222, 5); mov(edx, 9);                            /* mov edx, 0x9 */
            ii(0x1011_4227, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_422a, 6); mov(al, memb[ds, eax + 1432]);          /* mov al, [eax+0x598] */
            ii(0x1011_4230, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_4232, 1); cwde();                                 /* cwde */
            ii(0x1011_4233, 5); call(0x1013_9ade, 0x2_58a6);            /* call 0x10139ade */
        l_0x1011_4238:
            ii(0x1011_4238, 3); mov(eax, memd[ss, ebp - 18]);           /* mov eax, [ebp-0x12] */
            ii(0x1011_423b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_423e, 6); cmp(eax, memd[ds, edx + 1433]);         /* cmp eax, [edx+0x599] */
            ii(0x1011_4244, 6); if(jnz(0x1011_432d, 0xe3)) goto l_0x1011_432d; /* jnz 0x1011432d */
            ii(0x1011_424a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_424d, 4); mov(memb[ds, eax + 19], 0);             /* mov byte [eax+0x13], 0x0 */
            ii(0x1011_4251, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_4254, 7); cmp(memb[ds, eax + 1310], 0);           /* cmp byte [eax+0x51e], 0x0 */
            ii(0x1011_425b, 2); if(jz(0x1011_4292, 0x35)) goto l_0x1011_4292; /* jz 0x10114292 */
            ii(0x1011_425d, 7); mov(memb[ss, ebp - 188], 4);            /* mov byte [ebp-0xbc], 0x4 */
        l_0x1011_4264:
            ii(0x1011_4264, 6); dec(memb[ss, ebp - 188]);               /* dec byte [ebp-0xbc] */
            ii(0x1011_426a, 7); cmp(memb[ss, ebp - 188], -1 /* 0xff */); /* cmp byte [ebp-0xbc], 0xff */
            ii(0x1011_4271, 2); if(jz(0x1011_4288, 0x15)) goto l_0x1011_4288; /* jz 0x10114288 */
            ii(0x1011_4273, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_4275, 6); mov(al, memb[ss, ebp - 188]);           /* mov al, [ebp-0xbc] */
            ii(0x1011_427b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_427e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_4281, 5); call(0x1011_3129, -0x115d);             /* call 0x10113129 */
            ii(0x1011_4286, 2); jmp(0x1011_4264, -0x24); goto l_0x1011_4264; /* jmp 0x10114264 */
        l_0x1011_4288:
            ii(0x1011_4288, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_428b, 7); mov(memb[ds, eax + 1310], 0);           /* mov byte [eax+0x51e], 0x0 */
        l_0x1011_4292:
            ii(0x1011_4292, 7); mov(memb[ss, ebp - 188], 4);            /* mov byte [ebp-0xbc], 0x4 */
        l_0x1011_4299:
            ii(0x1011_4299, 6); dec(memb[ss, ebp - 188]);               /* dec byte [ebp-0xbc] */
            ii(0x1011_429f, 7); cmp(memb[ss, ebp - 188], -1 /* 0xff */); /* cmp byte [ebp-0xbc], 0xff */
            ii(0x1011_42a6, 2); if(jz(0x1011_42cc, 0x24)) goto l_0x1011_42cc; /* jz 0x101142cc */
            ii(0x1011_42a8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_42aa, 6); mov(al, memb[ss, ebp - 188]);           /* mov al, [ebp-0xbc] */
            ii(0x1011_42b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_42b2, 4); mov(dl, memb[ds, eax + ebp - 23]);      /* mov dl, [eax+ebp-0x17] */
            ii(0x1011_42b6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_42b8, 6); mov(al, memb[ss, ebp - 188]);           /* mov al, [ebp-0xbc] */
            ii(0x1011_42be, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_42c0, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1011_42c3, 7); mov(memw[ds, eax + 1252], dx);          /* mov [eax+0x4e4], dx */
            ii(0x1011_42ca, 2); jmp(0x1011_4299, -0x33); goto l_0x1011_4299; /* jmp 0x10114299 */
        l_0x1011_42cc:
            ii(0x1011_42cc, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_42d1, 5); call(0x1007_5fdc, -0x9_e2fa);           /* call 0x10075fdc */
            ii(0x1011_42d6, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1011_42d9, 2); if(jnz(0x1011_42eb, 0x10)) goto l_0x1011_42eb; /* jnz 0x101142eb */
            ii(0x1011_42db, 6); lea(edx, memd[ss, ebp - 184]);          /* lea edx, [ebp-0xb8] */
            ii(0x1011_42e1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_42e4, 5); call(0x1011_3f91, -0x358);              /* call 0x10113f91 */
            ii(0x1011_42e9, 2); jmp(0x1011_4321, 0x36); goto l_0x1011_4321; /* jmp 0x10114321 */
        l_0x1011_42eb:
            ii(0x1011_42eb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_42ed, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_42f0, 3); mov(al, memb[ds, edx + 17]);            /* mov al, [edx+0x11] */
            ii(0x1011_42f3, 6); mov(memd[ss, ebp - 192], eax);          /* mov [ebp-0xc0], eax */
            ii(0x1011_42f9, 7); movsx(edx, memw[ss, ebp - 192]);        /* movsx edx, word [ebp-0xc0] */
            ii(0x1011_4300, 6); cmp(edx, 0xff);                         /* cmp edx, 0xff */
            ii(0x1011_4306, 2); if(jnz(0x1011_4312, 0xa)) goto l_0x1011_4312; /* jnz 0x10114312 */
            ii(0x1011_4308, 10); mov(memd[ss, ebp - 192], 0);           /* mov dword [ebp-0xc0], 0x0 */
        l_0x1011_4312:
            ii(0x1011_4312, 7); movsx(edx, memw[ss, ebp - 192]);        /* movsx edx, word [ebp-0xc0] */
            ii(0x1011_4319, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_431c, 5); call(0x1011_3d56, -0x5cb);              /* call 0x10113d56 */
        l_0x1011_4321:
            ii(0x1011_4321, 10); mov(memd[ss, ebp - 196], 1);           /* mov dword [ebp-0xc4], 0x1 */
            ii(0x1011_432b, 2); jmp(0x1011_4388, 0x5b); goto l_0x1011_4388; /* jmp 0x10114388 */
        l_0x1011_432d:
            ii(0x1011_432d, 5); call(0x100c_aa00, -0x4_9932);           /* call 0x100caa00 */
            ii(0x1011_4332, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_4337, 1); push(eax);                              /* push eax */
            ii(0x1011_4338, 5); call(0x100c_aa20, -0x4_991d);           /* call 0x100caa20 */
            ii(0x1011_433d, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1011_4342, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_4344, 5); mov(esi, StringDefinitions.TheHostHasSelectedALoadFileThatIsNotCompatibleWithTheLoadFileOnYourSystemYouWillNotBeAbleToStartThisSessionUntilTheHostSelectsAn2); /* mov esi, 0x101a48ec */
            ii(0x1011_4349, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_434b, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1011_434d, 5); call(0x1011_5d23, 0x19d1);              /* call 0x10115d23 */
            ii(0x1011_4352, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_4355, 4); mov(memb[ds, eax + 19], 1);             /* mov byte [eax+0x13], 0x1 */
            ii(0x1011_4359, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_435c, 4); mov(memb[ds, eax + 11], 0);             /* mov byte [eax+0xb], 0x0 */
        l_0x1011_4360:
            ii(0x1011_4360, 2); jmp(0x1011_437e, 0x1c); goto l_0x1011_437e; /* jmp 0x1011437e */
        l_0x1011_4362:
            ii(0x1011_4362, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1011_4367, 5); call(0x1007_5fdc, -0x9_e390);           /* call 0x10075fdc */
            ii(0x1011_436c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_436f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_4372, 5); call(0x1011_4119, -0x25e);              /* call 0x10114119 */
            ii(0x1011_4377, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_437a, 4); mov(memb[ds, eax + 19], 0);             /* mov byte [eax+0x13], 0x0 */
        l_0x1011_437e:
            ii(0x1011_437e, 10); mov(memd[ss, ebp - 196], 0);           /* mov dword [ebp-0xc4], 0x0 */
        l_0x1011_4388:
            ii(0x1011_4388, 6); mov(eax, memd[ss, ebp - 196]);          /* mov eax, [ebp-0xc4] */
            ii(0x1011_438e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_4390, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_4391, 1); pop(edi);                               /* pop edi */
            ii(0x1011_4392, 1); pop(esi);                               /* pop esi */
            ii(0x1011_4393, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_4394, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_4395, 1); ret();                                  /* ret */
        }
    }
}
