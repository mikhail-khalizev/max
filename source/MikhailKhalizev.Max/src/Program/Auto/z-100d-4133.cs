using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4133-df0d7bcf")]
        public void Method_100d_4133()
        {
            ii(0x100d_4133, 5); push(0x58);                             /* push 0x58 */
            ii(0x100d_4138, 5); call(Definitions.sys_check_available_stack_size, 0x9_1c15); /* call 0x10165d52 */
            ii(0x100d_413d, 1); push(ebx);                              /* push ebx */
            ii(0x100d_413e, 1); push(ecx);                              /* push ecx */
            ii(0x100d_413f, 1); push(esi);                              /* push esi */
            ii(0x100d_4140, 1); push(edi);                              /* push edi */
            ii(0x100d_4141, 1); push(ebp);                              /* push ebp */
            ii(0x100d_4142, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4144, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x100d_414a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_414d, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_4150, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_4157, 2); if(jz(0x100d_4170, 0x17)) goto l_0x100d_4170; /* jz 0x100d4170 */
            ii(0x100d_4159, 5); mov(edx, 0x101b_5bfc);                  /* mov edx, 0x101b5bfc */
            ii(0x100d_415e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_4161, 5); call(Definitions.sys_call_dtor_arr, 0x9_1e52); /* call 0x10165fb8 */
            ii(0x100d_4166, 5); call(Definitions.sys_delete_arr, 0x9_1e6d); /* call 0x10165fd8 */
            ii(0x100d_416b, 5); jmp(0x100d_42c7, 0x157); goto l_0x100d_42c7; /* jmp 0x100d42c7 */
        l_0x100d_4170:
            ii(0x100d_4170, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_4173, 7); mov(memd[ds, eax + 0x13], 0x101b_5c50); /* mov dword [eax+0x13], 0x101b5c50 */
            ii(0x100d_417a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_417d, 6); mov(eax, memd[ds, eax + 0x8d]);         /* mov eax, [eax+0x8d] */
            ii(0x100d_4183, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100d_4186, 4); cmp(memd[ss, ebp - 0x3c], 0);           /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100d_418a, 2); if(jz(0x100d_41a7, 0x1b)) goto l_0x100d_41a7; /* jz 0x100d41a7 */
            ii(0x100d_418c, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100d_418f, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100d_4192, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100d_4195, 3); mov(ebx, memd[ds, eax + 0x40]);         /* mov ebx, [eax+0x40] */
            ii(0x100d_4198, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100d_419d, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100d_41a0, 2); call_abs(memd[ds, ebx]);                /* call dword [ebx] */
            ii(0x100d_41a2, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_41a5, 2); jmp(0x100d_41ae, 0x7); goto l_0x100d_41ae; /* jmp 0x100d41ae */
        l_0x100d_41a7:
            ii(0x100d_41a7, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
        l_0x100d_41ae:
            ii(0x100d_41ae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_41b1, 6); mov(eax, memd[ds, eax + 0x9d]);         /* mov eax, [eax+0x9d] */
            ii(0x100d_41b7, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100d_41ba, 4); cmp(memd[ss, ebp - 0x38], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100d_41be, 2); if(jz(0x100d_41d4, 0x14)) goto l_0x100d_41d4; /* jz 0x100d41d4 */
            ii(0x100d_41c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_41c2, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_41c5, 5); call(Definitions.my_dtor_d2, -0x5c92);  /* call 0x100ce538 */
            ii(0x100d_41ca, 5); call(Definitions.sys_delete, 0x9_1d95); /* call 0x10165f64 */
            ii(0x100d_41cf, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_41d2, 2); jmp(0x100d_41db, 0x7); goto l_0x100d_41db; /* jmp 0x100d41db */
        l_0x100d_41d4:
            ii(0x100d_41d4, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x100d_41db:
            ii(0x100d_41db, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_41de, 6); mov(eax, memd[ds, eax + 0xa1]);         /* mov eax, [eax+0xa1] */
            ii(0x100d_41e4, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_41e7, 4); cmp(memd[ss, ebp - 0x34], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100d_41eb, 2); if(jz(0x100d_4201, 0x14)) goto l_0x100d_4201; /* jz 0x100d4201 */
            ii(0x100d_41ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_41ef, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_41f2, 5); call(Definitions.my_dtor_d2, -0x5cbf);  /* call 0x100ce538 */
            ii(0x100d_41f7, 5); call(Definitions.sys_delete, 0x9_1d68); /* call 0x10165f64 */
            ii(0x100d_41fc, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_41ff, 2); jmp(0x100d_4208, 0x7); goto l_0x100d_4208; /* jmp 0x100d4208 */
        l_0x100d_4201:
            ii(0x100d_4201, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x100d_4208:
            ii(0x100d_4208, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_420b, 6); mov(eax, memd[ds, eax + 0xa5]);         /* mov eax, [eax+0xa5] */
            ii(0x100d_4211, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_4214, 4); cmp(memd[ss, ebp - 0x30], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100d_4218, 2); if(jz(0x100d_422e, 0x14)) goto l_0x100d_422e; /* jz 0x100d422e */
            ii(0x100d_421a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_421c, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100d_421f, 5); call(Definitions.my_dtor_d2, -0x5cec);  /* call 0x100ce538 */
            ii(0x100d_4224, 5); call(Definitions.sys_delete, 0x9_1d3b); /* call 0x10165f64 */
            ii(0x100d_4229, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_422c, 2); jmp(0x100d_4235, 0x7); goto l_0x100d_4235; /* jmp 0x100d4235 */
        l_0x100d_422e:
            ii(0x100d_422e, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x100d_4235:
            ii(0x100d_4235, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_4238, 6); mov(eax, memd[ds, eax + 0x95]);         /* mov eax, [eax+0x95] */
            ii(0x100d_423e, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_4241, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x100d_4245, 2); if(jz(0x100d_425b, 0x14)) goto l_0x100d_425b; /* jz 0x100d425b */
            ii(0x100d_4247, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4249, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100d_424c, 5); call(Definitions.my_dtor_d2, -0x5d19);  /* call 0x100ce538 */
            ii(0x100d_4251, 5); call(Definitions.sys_delete, 0x9_1d0e); /* call 0x10165f64 */
            ii(0x100d_4256, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_4259, 2); jmp(0x100d_4262, 0x7); goto l_0x100d_4262; /* jmp 0x100d4262 */
        l_0x100d_425b:
            ii(0x100d_425b, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x100d_4262:
            ii(0x100d_4262, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_4265, 6); mov(eax, memd[ds, eax + 0x99]);         /* mov eax, [eax+0x99] */
            ii(0x100d_426b, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_426e, 4); cmp(memd[ss, ebp - 0x28], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100d_4272, 2); if(jz(0x100d_4288, 0x14)) goto l_0x100d_4288; /* jz 0x100d4288 */
            ii(0x100d_4274, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4276, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_4279, 5); call(Definitions.my_dtor_d2, -0x5d46);  /* call 0x100ce538 */
            ii(0x100d_427e, 5); call(Definitions.sys_delete, 0x9_1ce1); /* call 0x10165f64 */
            ii(0x100d_4283, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_4286, 2); jmp(0x100d_428f, 0x7); goto l_0x100d_428f; /* jmp 0x100d428f */
        l_0x100d_4288:
            ii(0x100d_4288, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100d_428f:
            ii(0x100d_428f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4291, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_4294, 5); add(eax, 0x87);                         /* add eax, 0x87 */
            ii(0x100d_4299, 5); call(0x1008_8b04, -0x4_b79a);           /* call 0x10088b04 */
            ii(0x100d_429e, 5); sub(eax, 0x87);                         /* sub eax, 0x87 */
            ii(0x100d_42a3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_42a6, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_42ab, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_42ae, 5); call(0x100d_10b2, -0x3201);             /* call 0x100d10b2 */
            ii(0x100d_42b3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_42b6, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_42bd, 2); if(jz(0x100d_42c7, 0x8)) goto l_0x100d_42c7; /* jz 0x100d42c7 */
            ii(0x100d_42bf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_42c2, 5); call(Definitions.sys_delete, 0x9_1c9d); /* call 0x10165f64 */
        l_0x100d_42c7:
            ii(0x100d_42c7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_42ca, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_42cd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_42d0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_42d2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_42d3, 1); pop(edi);                               /* pop edi */
            ii(0x100d_42d4, 1); pop(esi);                               /* pop esi */
            ii(0x100d_42d5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_42d6, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_42d7, 1); ret();                                  /* ret */
        }
    }
}
