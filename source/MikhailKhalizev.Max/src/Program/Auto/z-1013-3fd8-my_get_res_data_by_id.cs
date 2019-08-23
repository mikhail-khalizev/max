using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3fd8-b65acfe0")]
        public void my_get_res_data_by_id()
        {
            ii(0x1013_3fd8, 5); push(0x34);                             /* push 0x34 */
            ii(0x1013_3fdd, 5); call(Definitions.sys_check_available_stack_size, 0x3_1d70); /* call 0x10165d52 */
            ii(0x1013_3fe2, 1); push(ebx);                              /* push ebx */
            ii(0x1013_3fe3, 1); push(ecx);                              /* push ecx */
            ii(0x1013_3fe4, 1); push(edx);                              /* push edx */
            ii(0x1013_3fe5, 1); push(esi);                              /* push esi */
            ii(0x1013_3fe6, 1); push(edi);                              /* push edi */
            ii(0x1013_3fe7, 1); push(ebp);                              /* push ebp */
            ii(0x1013_3fe8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3fea, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_3ff0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_3ff3, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_3ff7, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1013_3ffa, 2); if(jnz(0x1013_4008, 0xc)) goto l_0x1013_4008; /* jnz 0x10134008 */
            ii(0x1013_3ffc, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1013_4003, 5); jmp(0x1013_414b, 0x143); goto l_0x1013_414b; /* jmp 0x1013414b */
        l_0x1013_4008:
            ii(0x1013_4008, 6); cmp(memw[ss, ebp - 0x4], 0x38e);        /* cmp word [ebp-0x4], 0x38e */
            ii(0x1013_400e, 2); if(jge(0x1013_4019, 0x9)) goto l_0x1013_4019; /* jge 0x10134019 */
            ii(0x1013_4010, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_4017, 2); jmp(0x1013_4032, 0x19); goto l_0x1013_4032; /* jmp 0x10134032 */
        l_0x1013_4019:
            ii(0x1013_4019, 5); mov(ecx, 0xb6e);                        /* mov ecx, 0xb6e */
            ii(0x1013_401e, 5); mov(ebx, StringDefinitions.ResrcmgrCpp2); /* mov ebx, 0x101a89a4 */
            ii(0x1013_4023, 5); mov(edx, StringDefinitions.DirnameidLessEndMemoryResources); /* mov edx, 0x101a89b1 */
            ii(0x1013_4028, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_402a, 5); call(Definitions.sys_assert, 0x3_1d63); /* call 0x10165d92 */
            ii(0x1013_402f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1013_4032:
            ii(0x1013_4032, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_4036, 3); imul(edx, eax, 0x7);                    /* imul edx, eax, 0x7 */
            ii(0x1013_4039, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_403e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4040, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1013_4043, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_4046, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_404a, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1013_404d, 2); if(jnz(0x1013_405b, 0xc)) goto l_0x1013_405b; /* jnz 0x1013405b */
            ii(0x1013_404f, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1013_4056, 5); jmp(0x1013_414b, 0xf0); goto l_0x1013_414b; /* jmp 0x1013414b */
        l_0x1013_405b:
            ii(0x1013_405b, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_405f, 3); imul(edx, eax, 0x7);                    /* imul edx, eax, 0x7 */
            ii(0x1013_4062, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_4067, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4069, 3); mov(eax, memd[ds, eax + 0x2]);          /* mov eax, [eax+0x2] */
            ii(0x1013_406c, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_406f, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_4073, 6); if(jnz(0x1013_4145, 0xcc)) goto l_0x1013_4145; /* jnz 0x10134145 */
            ii(0x1013_4079, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_407d, 3); imul(eax, eax, 0x7);                    /* imul eax, eax, 0x7 */
            ii(0x1013_4080, 6); mov(edx, memd[ds, Definitions.ptr_arr_meta_by_id]); /* mov edx, [0x101c70ec] */
            ii(0x1013_4086, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4088, 3); mov(al, memb[ds, eax + 0x6]);           /* mov al, [eax+0x6] */
            ii(0x1013_408b, 3); mov(memb[ss, ebp - 0x18], al);          /* mov [ebp-0x18], al */
            ii(0x1013_408e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_4090, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1013_4094, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1013_4097, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta]); /* mov eax, [0x101c70f0] */
            ii(0x1013_409c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_409e, 3); mov(edx, memd[ds, edx + 0x8]);          /* mov edx, [edx+0x8] */
            ii(0x1013_40a1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_40a3, 3); mov(al, memb[ss, ebp - 0x18]);          /* mov al, [ebp-0x18] */
            ii(0x1013_40a6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_40a9, 6); mov(eax, memd[ds, eax + Definitions.arr_res_file]); /* mov eax, [eax+0x101c70d0] */
            ii(0x1013_40af, 5); call(Definitions.my_fseek, -0x4_4c5f);  /* call 0x100ef455 */
            ii(0x1013_40b4, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_40b8, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1013_40bb, 6); mov(edx, memd[ds, Definitions.ptr_arr_meta]); /* mov edx, [0x101c70f0] */
            ii(0x1013_40c1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_40c3, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1013_40c6, 5); call(Definitions.sys_new_arr, 0x3_1f45); /* call 0x10166010 */
            ii(0x1013_40cb, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_40ce, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_40d2, 2); if(jnz(0x1013_40de, 0xa)) goto l_0x1013_40de; /* jnz 0x101340de */
            ii(0x1013_40d4, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1013_40d9, 5); call(0x100e_f3a0, -0x4_4d3e);           /* call 0x100ef3a0 */
        l_0x1013_40de:
            ii(0x1013_40de, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_40e0, 3); mov(al, memb[ss, ebp - 0x18]);          /* mov al, [ebp-0x18] */
            ii(0x1013_40e3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_40e6, 6); mov(ecx, memd[ds, eax + Definitions.arr_res_file]); /* mov ecx, [eax+0x101c70d0] */
            ii(0x1013_40ec, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_40f1, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_40f5, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1013_40f8, 6); mov(edx, memd[ds, Definitions.ptr_arr_meta]); /* mov edx, [0x101c70f0] */
            ii(0x1013_40fe, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4100, 3); mov(edx, memd[ds, eax + 0xc]);          /* mov edx, [eax+0xc] */
            ii(0x1013_4103, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_4106, 5); call(Definitions.my_fread, -0x4_4c7c);  /* call 0x100ef48f */
            ii(0x1013_410b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_410d, 2); if(jnz(0x1013_4119, 0xa)) goto l_0x1013_4119; /* jnz 0x10134119 */
            ii(0x1013_410f, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1013_4114, 5); call(0x100e_f3a0, -0x4_4d79);           /* call 0x100ef3a0 */
        l_0x1013_4119:
            ii(0x1013_4119, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_411d, 3); imul(edx, edx, 0x7);                    /* imul edx, edx, 0x7 */
            ii(0x1013_4120, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_4125, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_4127, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_412a, 3); mov(memd[ds, edx + 0x2], eax);          /* mov [edx+0x2], eax */
            ii(0x1013_412d, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_4131, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1013_4134, 6); mov(edx, memd[ds, Definitions.ptr_arr_meta]); /* mov edx, [0x101c70f0] */
            ii(0x1013_413a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_413c, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1013_413f, 6); add(memd[ds, 0x101c_70dc], eax);        /* add [0x101c70dc], eax */
        l_0x1013_4145:
            ii(0x1013_4145, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_4148, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x1013_414b:
            ii(0x1013_414b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_414e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_4150, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_4151, 1); pop(edi);                               /* pop edi */
            ii(0x1013_4152, 1); pop(esi);                               /* pop esi */
            ii(0x1013_4153, 1); pop(edx);                               /* pop edx */
            ii(0x1013_4154, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_4155, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_4156, 1); ret();                                  /* ret */
        }
    }
}
