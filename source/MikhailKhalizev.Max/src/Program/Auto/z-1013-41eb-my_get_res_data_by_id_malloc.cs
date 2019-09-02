using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_41eb-bc68cf90")]
        public void my_get_res_data_by_id_malloc()
        {
            ii(0x1013_41eb, 5); push(0x34);                             /* push 0x34 */
            ii(0x1013_41f0, 5); call(Definitions.sys_check_available_stack_size, 0x3_1b5d); /* call 0x10165d52 */
            ii(0x1013_41f5, 1); push(ebx);                              /* push ebx */
            ii(0x1013_41f6, 1); push(ecx);                              /* push ecx */
            ii(0x1013_41f7, 1); push(edx);                              /* push edx */
            ii(0x1013_41f8, 1); push(esi);                              /* push esi */
            ii(0x1013_41f9, 1); push(edi);                              /* push edi */
            ii(0x1013_41fa, 1); push(ebp);                              /* push ebp */
            ii(0x1013_41fb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_41fd, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_4203, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_4206, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_420a, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1013_420d, 2); if(jnz(0x1013_421b, 0xc)) goto l_0x1013_421b; /* jnz 0x1013421b */
            ii(0x1013_420f, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_4216, 5); jmp(0x1013_4332, 0x117); goto l_0x1013_4332; /* jmp 0x10134332 */
        l_0x1013_421b:
            ii(0x1013_421b, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_421f, 5); cmp(eax, 0x38e);                        /* cmp eax, 0x38e */
            ii(0x1013_4224, 2); if(jle(0x1013_422f, 9)) goto l_0x1013_422f; /* jle 0x1013422f */
            ii(0x1013_4226, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_422d, 2); jmp(0x1013_4248, 0x19); goto l_0x1013_4248; /* jmp 0x10134248 */
        l_0x1013_422f:
            ii(0x1013_422f, 5); mov(ecx, 0xbac);                        /* mov ecx, 0xbac */
            ii(0x1013_4234, 5); mov(ebx, StringDefinitions.ResrcmgrCpp); /* mov ebx, 0x101a89d2 */
            ii(0x1013_4239, 5); mov(edx, StringDefinitions.IdGreaterEndMemoryResources); /* mov edx, 0x101a89df */
            ii(0x1013_423e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_4240, 5); call(Definitions.sys_assert, 0x3_1b4d); /* call 0x10165d92 */
            ii(0x1013_4245, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x1013_4248:
            ii(0x1013_4248, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_424c, 3); imul(edx, eax, 7);                      /* imul edx, eax, 0x7 */
            ii(0x1013_424f, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_4254, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4256, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1013_4259, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_425c, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_4260, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1013_4263, 2); if(jnz(0x1013_4271, 0xc)) goto l_0x1013_4271; /* jnz 0x10134271 */
            ii(0x1013_4265, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_426c, 5); jmp(0x1013_4332, 0xc1); goto l_0x1013_4332; /* jmp 0x10134332 */
        l_0x1013_4271:
            ii(0x1013_4271, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_4275, 3); imul(eax, eax, 7);                      /* imul eax, eax, 0x7 */
            ii(0x1013_4278, 6); mov(edx, memd[ds, Definitions.ptr_arr_meta_by_id]); /* mov edx, [0x101c70ec] */
            ii(0x1013_427e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4280, 3); mov(al, memb[ds, eax + 6]);             /* mov al, [eax+0x6] */
            ii(0x1013_4283, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1013_4286, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_4288, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1013_428c, 3); shl(edx, 4);                            /* shl edx, 0x4 */
            ii(0x1013_428f, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta]); /* mov eax, [0x101c70f0] */
            ii(0x1013_4294, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_4296, 3); mov(edx, memd[ds, edx + 8]);            /* mov edx, [edx+0x8] */
            ii(0x1013_4299, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_429b, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1013_429e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_42a1, 6); mov(eax, memd[ds, eax + Definitions.arr_res_file]); /* mov eax, [eax+0x101c70d0] */
            ii(0x1013_42a7, 5); call(Definitions.my_fseek, -0x4_4e57);  /* call 0x100ef455 */
            ii(0x1013_42ac, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_42b0, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1013_42b3, 6); mov(edx, memd[ds, Definitions.ptr_arr_meta]); /* mov edx, [0x101c70f0] */
            ii(0x1013_42b9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_42bb, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1013_42be, 1); inc(eax);                               /* inc eax */
            ii(0x1013_42bf, 5); call(Definitions.sys_new_arr, 0x3_1d4c); /* call 0x10166010 */
            ii(0x1013_42c4, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_42c7, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1013_42cb, 2); if(jnz(0x1013_42d7, 0xa)) goto l_0x1013_42d7; /* jnz 0x101342d7 */
            ii(0x1013_42cd, 5); mov(eax, 3);                            /* mov eax, 0x3 */
            ii(0x1013_42d2, 5); call(0x100e_f3a0, -0x4_4f37);           /* call 0x100ef3a0 */
        l_0x1013_42d7:
            ii(0x1013_42d7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_42d9, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1013_42dc, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_42df, 6); mov(ecx, memd[ds, eax + Definitions.arr_res_file]); /* mov ecx, [eax+0x101c70d0] */
            ii(0x1013_42e5, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_42ea, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_42ee, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1013_42f1, 6); mov(edx, memd[ds, Definitions.ptr_arr_meta]); /* mov edx, [0x101c70f0] */
            ii(0x1013_42f7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_42f9, 3); mov(edx, memd[ds, eax + 0xc]);          /* mov edx, [eax+0xc] */
            ii(0x1013_42fc, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_42ff, 5); call(Definitions.my_fread, -0x4_4e75);  /* call 0x100ef48f */
            ii(0x1013_4304, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_4306, 2); if(jnz(0x1013_4312, 0xa)) goto l_0x1013_4312; /* jnz 0x10134312 */
            ii(0x1013_4308, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_430d, 5); call(0x100e_f3a0, -0x4_4f72);           /* call 0x100ef3a0 */
        l_0x1013_4312:
            ii(0x1013_4312, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_4316, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1013_4319, 6); mov(edx, memd[ds, Definitions.ptr_arr_meta]); /* mov edx, [0x101c70f0] */
            ii(0x1013_431f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4321, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1013_4324, 3); add(edx, memd[ds, eax + 0xc]);          /* add edx, [eax+0xc] */
            ii(0x1013_4327, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_4329, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1013_432c, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_432f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1013_4332:
            ii(0x1013_4332, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_4335, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_4337, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_4338, 1); pop(edi);                               /* pop edi */
            ii(0x1013_4339, 1); pop(esi);                               /* pop esi */
            ii(0x1013_433a, 1); pop(edx);                               /* pop edx */
            ii(0x1013_433b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_433c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_433d, 1); ret();                                  /* ret */
        }
    }
}
