using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_43b3-624a72b3")]
        public void Method_1013_43b3()
        {
            ii(0x1013_43b3, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1013_43b8, 5); call(Definitions.sys_check_available_stack_size, 0x3_1995); /* call 0x10165d52 */
            ii(0x1013_43bd, 1); push(ebx);                              /* push ebx */
            ii(0x1013_43be, 1); push(ecx);                              /* push ecx */
            ii(0x1013_43bf, 1); push(edx);                              /* push edx */
            ii(0x1013_43c0, 1); push(esi);                              /* push esi */
            ii(0x1013_43c1, 1); push(edi);                              /* push edi */
            ii(0x1013_43c2, 1); push(ebp);                              /* push ebp */
            ii(0x1013_43c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_43c5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_43cb, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_43ce, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_43d2, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1013_43d5, 2); if(jnz(0x1013_43e0, 9)) goto l_0x1013_43e0; /* jnz 0x101343e0 */
            ii(0x1013_43d7, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_43de, 2); jmp(0x1013_4454, 0x74); goto l_0x1013_4454; /* jmp 0x10134454 */
        l_0x1013_43e0:
            ii(0x1013_43e0, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_43e4, 3); imul(edx, eax, 7);                      /* imul edx, eax, 0x7 */
            ii(0x1013_43e7, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]); /* mov eax, [0x101c70ec] */
            ii(0x1013_43ec, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_43ee, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1013_43f1, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_43f4, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_43f8, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1013_43fb, 2); if(jnz(0x1013_4406, 9)) goto l_0x1013_4406; /* jnz 0x10134406 */
            ii(0x1013_43fd, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_4404, 2); jmp(0x1013_4454, 0x4e); goto l_0x1013_4454; /* jmp 0x10134454 */
        l_0x1013_4406:
            ii(0x1013_4406, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_440a, 3); imul(eax, eax, 7);                      /* imul eax, eax, 0x7 */
            ii(0x1013_440d, 6); mov(edx, memd[ds, Definitions.ptr_arr_meta_by_id]); /* mov edx, [0x101c70ec] */
            ii(0x1013_4413, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_4415, 3); mov(al, memb[ds, eax + 6]);             /* mov al, [eax+0x6] */
            ii(0x1013_4418, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1013_441b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_441d, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_4421, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1013_4424, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_4426, 5); mov(eax, memd[ds, Definitions.ptr_arr_meta]); /* mov eax, [0x101c70f0] */
            ii(0x1013_442b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_442d, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1013_4430, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_4432, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1013_4435, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_4438, 6); mov(eax, memd[ds, eax + Definitions.arr_res_file]); /* mov eax, [eax+0x101c70d0] */
            ii(0x1013_443e, 5); call(Definitions.my_fseek, -0x4_4fee);  /* call 0x100ef455 */
            ii(0x1013_4443, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_4445, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1013_4448, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_444b, 6); mov(eax, memd[ds, eax + Definitions.arr_res_file]); /* mov eax, [eax+0x101c70d0] */
            ii(0x1013_4451, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1013_4454:
            ii(0x1013_4454, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_4457, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_4459, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_445a, 1); pop(edi);                               /* pop edi */
            ii(0x1013_445b, 1); pop(esi);                               /* pop esi */
            ii(0x1013_445c, 1); pop(edx);                               /* pop edx */
            ii(0x1013_445d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_445e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_445f, 1); ret();                                  /* ret */
        }
    }
}
