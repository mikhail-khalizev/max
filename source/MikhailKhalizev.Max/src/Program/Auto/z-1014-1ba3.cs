using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1ba3-7a8f3c61")]
        public void Method_1014_1ba3()
        {
            ii(0x1014_1ba3, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1014_1ba8, 5); calld(Definitions.sys_check_available_stack_size, 0x2_41a5); /* call 0x10165d52 */
            ii(0x1014_1bad, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1bae, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1baf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1bb0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1bb2, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_1bb8, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_1bbb, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_1bbe, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1014_1bc1, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1014_1bc4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_1bc7, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1bc9, 5); calld(Definitions.my_strobj_get_len, -0x5_6caa); /* call 0x100eaf24 */
            ii(0x1014_1bce, 1); cwde();                                 /* cwde */
            ii(0x1014_1bcf, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_1bd3, 1); dec(eax);                               /* dec eax */
            ii(0x1014_1bd4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_1bd6, 2); if(jled(0x1014_1be6, 0xe)) goto l_0x1014_1be6; /* jle 0x10141be6 */
            ii(0x1014_1bd8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_1bdb, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1bdd, 5); calld(Definitions.my_strobj_get_len, -0x5_6cbe); /* call 0x100eaf24 */
            ii(0x1014_1be2, 1); dec(eax);                               /* dec eax */
            ii(0x1014_1be3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1014_1be6:
            ii(0x1014_1be6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1be9, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1014_1bed, 2); if(jged(0x1014_1c01, 0x12)) goto l_0x1014_1c01; /* jge 0x10141c01 */
            ii(0x1014_1bef, 5); mov(edx, 0x101c_8118);                  /* mov edx, 0x101c8118 */
            ii(0x1014_1bf4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_1bf7, 5); calld(Definitions.my_string_ctor_string, -0x156); /* call 0x10141aa6 */
            ii(0x1014_1bfc, 5); jmpd(0x1014_1c80, 0x7f); goto l_0x1014_1c80; /* jmp 0x10141c80 */
        l_0x1014_1c01:
            ii(0x1014_1c01, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1c04, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1014_1c07, 1); inc(eax);                               /* inc eax */
            ii(0x1014_1c08, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_1c0b, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1014_1c0f, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1014_1c13, 1); inc(edx);                               /* inc edx */
            ii(0x1014_1c14, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_1c17, 5); calld(Definitions.my_string_ctor_capaticy, -0x24c); /* call 0x101419d0 */
            ii(0x1014_1c1c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_1c1f, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1014_1c23, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x1014_1c27, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_1c2a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1c2c, 5); calld(Definitions.my_strobj_c_str, -0xb_8435); /* call 0x100897fc */
            ii(0x1014_1c31, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1014_1c35, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_1c37, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_1c3a, 5); calld(Definitions.my_strobj_c_str, -0xb_8443); /* call 0x100897fc */
            ii(0x1014_1c3f, 5); calld(Definitions.sys_strncpy, 0x3_029c); /* call 0x10171ee0 */
            ii(0x1014_1c44, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1014_1c48, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_1c4b, 5); calld(Definitions.my_string_get, 0x642); /* call 0x10142292 */
            ii(0x1014_1c50, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x1014_1c53, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1014_1c57, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_1c5a, 5); calld(Definitions.my_strobj_set_len, 0x88d); /* call 0x101424ec */
            ii(0x1014_1c5f, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1014_1c62, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_1c65, 5); calld(Definitions.my_string_ctor_string, -0x1c4); /* call 0x10141aa6 */
            ii(0x1014_1c6a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_1c6c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_1c6f, 5); calld(Definitions.my_string_dtor, -0x14a); /* call 0x10141b2a */
            ii(0x1014_1c74, 2); jmpd(0x1014_1c80, 0xa); goto l_0x1014_1c80; /* jmp 0x10141c80 */
        //  ii(0x1014_1c76, 10); Недостижимый код.
        l_0x1014_1c80:
            ii(0x1014_1c80, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_1c83, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1c85, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1c86, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1c87, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1c88, 1); retd(); return;                         /* ret */
        }
    }
}
