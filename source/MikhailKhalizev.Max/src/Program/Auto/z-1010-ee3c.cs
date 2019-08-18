using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ccd9bfd6-6738-4efd-9115-329c1fb2a14b")]
        public void Method_1010_ee3c()
        {
            ii(0x1010_ee3c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_ee41, 5); calld(Definitions.sys_check_available_stack_size, 0x5_6f0c); /* call 0x10165d52 */
            ii(0x1010_ee46, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_ee47, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_ee48, 1); pushd(edx);                             /* push edx */
            ii(0x1010_ee49, 1); pushd(esi);                             /* push esi */
            ii(0x1010_ee4a, 1); pushd(edi);                             /* push edi */
            ii(0x1010_ee4b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_ee4c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_ee4e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_ee54, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_ee57, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_ee5c, 5); calld(/* sys */ 0x1016_a24c, 0x5_b3eb); /* call 0x1016a24c */
            ii(0x1010_ee61, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_ee68, 2); jmpd(0x1010_ee70, 0x6); goto l_0x1010_ee70; /* jmp 0x1010ee70 */
        l_0x1010_ee6a:
            ii(0x1010_ee6a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_ee6d, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1010_ee70:
            ii(0x1010_ee70, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_ee74, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_ee77, 2); if(jgd(0x1010_eed3, 0x5a)) goto l_0x1010_eed3; /* jg 0x1010eed3 */
            ii(0x1010_ee79, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ee7c, 2); pushd(memd_a32[ds, eax]);               /* push dword [eax] */
            ii(0x1010_ee7e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_ee80, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_ee84, 3); imul(ebx, ebx, 0x14);                   /* imul ebx, ebx, 0x14 */
            ii(0x1010_ee87, 6); mov(ebx, memd_a32[ds, ebx + 0x101b_ab3c]); /* mov ebx, [ebx+0x101bab3c] */
            ii(0x1010_ee8d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_ee91, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_ee94, 6); mov(edx, memd_a32[ds, eax + 0x101b_ab38]); /* mov edx, [eax+0x101bab38] */
            ii(0x1010_ee9a, 5); mov(eax, 0x22b);                        /* mov eax, 0x22b */
            ii(0x1010_ee9f, 5); calld(0x100e_8ef1, -0x2_5fb3);          /* call 0x100e8ef1 */
            ii(0x1010_eea4, 5); calld(0x1011_5318, 0x646f);             /* call 0x10115318 */
            ii(0x1010_eea9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_eeae, 1); pushd(eax);                             /* push eax */
            ii(0x1010_eeaf, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_eeb4, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x1010_eeb9, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_eebd, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_eec0, 5); mov(edx, 0x101b_ab38);                  /* mov edx, 0x101bab38 */
            ii(0x1010_eec5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_eec7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_eeca, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_eecc, 5); calld(0x1010_8a05, -0x64cc);            /* call 0x10108a05 */
            ii(0x1010_eed1, 2); jmpd(0x1010_ee6a, -0x69); goto l_0x1010_ee6a; /* jmp 0x1010ee6a */
        l_0x1010_eed3:
            ii(0x1010_eed3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_eed6, 3); mov(al, memb_a32[ds, eax + 0x14]);      /* mov al, [eax+0x14] */
            ii(0x1010_eed9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_eede, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_eee1, 2); if(jnzd(0x1010_ef55, 0x72)) goto l_0x1010_ef55; /* jnz 0x1010ef55 */
            ii(0x1010_eee3, 7); mov(memd_a32[ss, ebp - 0x8], 0x3);      /* mov dword [ebp-0x8], 0x3 */
            ii(0x1010_eeea, 2); jmpd(0x1010_eef2, 0x6); goto l_0x1010_eef2; /* jmp 0x1010eef2 */
        l_0x1010_eeec:
            ii(0x1010_eeec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_eeef, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1010_eef2:
            ii(0x1010_eef2, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_eef6, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x1010_eef9, 2); if(jgd(0x1010_ef55, 0x5a)) goto l_0x1010_ef55; /* jg 0x1010ef55 */
            ii(0x1010_eefb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_eefe, 2); pushd(memd_a32[ds, eax]);               /* push dword [eax] */
            ii(0x1010_ef00, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_ef02, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_ef06, 3); imul(ebx, ebx, 0x14);                   /* imul ebx, ebx, 0x14 */
            ii(0x1010_ef09, 6); mov(ebx, memd_a32[ds, ebx + 0x101b_ab3c]); /* mov ebx, [ebx+0x101bab3c] */
            ii(0x1010_ef0f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_ef13, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_ef16, 6); mov(edx, memd_a32[ds, eax + 0x101b_ab38]); /* mov edx, [eax+0x101bab38] */
            ii(0x1010_ef1c, 5); mov(eax, 0x22b);                        /* mov eax, 0x22b */
            ii(0x1010_ef21, 5); calld(0x100e_8ef1, -0x2_6035);          /* call 0x100e8ef1 */
            ii(0x1010_ef26, 5); calld(0x1011_5318, 0x63ed);             /* call 0x10115318 */
            ii(0x1010_ef2b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_ef30, 1); pushd(eax);                             /* push eax */
            ii(0x1010_ef31, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_ef36, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x1010_ef3b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_ef3f, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_ef42, 5); mov(edx, 0x101b_ab38);                  /* mov edx, 0x101bab38 */
            ii(0x1010_ef47, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_ef49, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ef4c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_ef4e, 5); calld(0x1010_8a05, -0x654e);            /* call 0x10108a05 */
            ii(0x1010_ef53, 2); jmpd(0x1010_eeec, -0x69); goto l_0x1010_eeec; /* jmp 0x1010eeec */
        l_0x1010_ef55:
            ii(0x1010_ef55, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ef58, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_ef5a, 5); calld(0x1010_eda6, -0x1b9);             /* call 0x1010eda6 */
            ii(0x1010_ef5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ef62, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_ef64, 5); calld(0x1010_edfe, -0x16b);             /* call 0x1010edfe */
            ii(0x1010_ef69, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ef6c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_ef6e, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_ef71, 5); calld(Definitions.sys_display_draw_0, 0x5_850e); /* call 0x10167484 */
            ii(0x1010_ef76, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_ef78, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_ef79, 1); popd(edi);                              /* pop edi */
            ii(0x1010_ef7a, 1); popd(esi);                              /* pop esi */
            ii(0x1010_ef7b, 1); popd(edx);                              /* pop edx */
            ii(0x1010_ef7c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_ef7d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_ef7e, 1); retd(); return;                         /* ret */
        }
    }
}
