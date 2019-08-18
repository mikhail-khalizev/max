using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_68e2-6a33a987")]
        public void Method_1014_68e2()
        {
            ii(0x1014_68e2, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_68e7, 5); calld(Definitions.sys_check_available_stack_size, 0x1_f466); /* call 0x10165d52 */
            ii(0x1014_68ec, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_68ed, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_68ee, 1); pushd(edx);                             /* push edx */
            ii(0x1014_68ef, 1); pushd(esi);                             /* push esi */
            ii(0x1014_68f0, 1); pushd(edi);                             /* push edi */
            ii(0x1014_68f1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_68f2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_68f4, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_68fa, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1014_68fd:
            ii(0x1014_68fd, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1014_6901:
            ii(0x1014_6901, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6904, 4); cmp(memd_a32[ds, eax + 0x1c], 0x20);    /* cmp dword [eax+0x1c], 0x20 */
            ii(0x1014_6908, 2); if(jzd(0x1014_6913, 0x9)) goto l_0x1014_6913; /* jz 0x10146913 */
            ii(0x1014_690a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_690d, 4); cmp(memd_a32[ds, eax + 0x1c], 0xa);     /* cmp dword [eax+0x1c], 0xa */
            ii(0x1014_6911, 2); if(jnzd(0x1014_6915, 0x2)) goto l_0x1014_6915; /* jnz 0x10146915 */
        l_0x1014_6913:
            ii(0x1014_6913, 2); jmpd(0x1014_691e, 0x9); goto l_0x1014_691e; /* jmp 0x1014691e */
        l_0x1014_6915:
            ii(0x1014_6915, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6918, 4); cmp(memd_a32[ds, eax + 0x1c], 0x9);     /* cmp dword [eax+0x1c], 0x9 */
            ii(0x1014_691c, 2); if(jnzd(0x1014_6928, 0xa)) goto l_0x1014_6928; /* jnz 0x10146928 */
        l_0x1014_691e:
            ii(0x1014_691e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6921, 5); calld(0x1014_6722, -0x204);             /* call 0x10146722 */
            ii(0x1014_6926, 2); jmpd(0x1014_6901, -0x27); goto l_0x1014_6901; /* jmp 0x10146901 */
        l_0x1014_6928:
            ii(0x1014_6928, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_692b, 4); cmp(memd_a32[ds, eax + 0x1c], 0x2f);    /* cmp dword [eax+0x1c], 0x2f */
            ii(0x1014_692f, 2); if(jnzd(0x1014_6947, 0x16)) goto l_0x1014_6947; /* jnz 0x10146947 */
            ii(0x1014_6931, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6934, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_6937, 5); calld(0x100e_aef0, -0x5_ba4c);          /* call 0x100eaef0 */
            ii(0x1014_693c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_693e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6941, 4); cmp(dx, memw_a32[ds, eax + 0x1a]);      /* cmp dx, [eax+0x1a] */
            ii(0x1014_6945, 2); if(jgd(0x1014_6949, 0x2)) goto l_0x1014_6949; /* jg 0x10146949 */
        l_0x1014_6947:
            ii(0x1014_6947, 2); jmpd(0x1014_6962, 0x19); goto l_0x1014_6962; /* jmp 0x10146962 */
        l_0x1014_6949:
            ii(0x1014_6949, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_694c, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1014_694f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_6952, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6955, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_6958, 5); calld(Definitions.my_string_get, -0x46cb); /* call 0x10142292 */
            ii(0x1014_695d, 3); cmp(memb_a32[ds, eax], 0x2f);           /* cmp byte [eax], 0x2f */
            ii(0x1014_6960, 2); if(jzd(0x1014_6964, 0x2)) goto l_0x1014_6964; /* jz 0x10146964 */
        l_0x1014_6962:
            ii(0x1014_6962, 2); jmpd(0x1014_6986, 0x22); goto l_0x1014_6986; /* jmp 0x10146986 */
        l_0x1014_6964:
            ii(0x1014_6964, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6967, 4); cmp(memd_a32[ds, eax + 0x1c], 0xa);     /* cmp dword [eax+0x1c], 0xa */
            ii(0x1014_696b, 2); if(jzd(0x1014_6976, 0x9)) goto l_0x1014_6976; /* jz 0x10146976 */
            ii(0x1014_696d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6970, 4); cmp(memd_a32[ds, eax + 0x1c], -0x1 /* 0xff */); /* cmp dword [eax+0x1c], 0xffffffff */
            ii(0x1014_6974, 2); if(jnzd(0x1014_6978, 0x2)) goto l_0x1014_6978; /* jnz 0x10146978 */
        l_0x1014_6976:
            ii(0x1014_6976, 2); jmpd(0x1014_6982, 0xa); goto l_0x1014_6982; /* jmp 0x10146982 */
        l_0x1014_6978:
            ii(0x1014_6978, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_697b, 5); calld(0x1014_6722, -0x25e);             /* call 0x10146722 */
            ii(0x1014_6980, 2); jmpd(0x1014_6964, -0x1e); goto l_0x1014_6964; /* jmp 0x10146964 */
        l_0x1014_6982:
            ii(0x1014_6982, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x1014_6986:
            ii(0x1014_6986, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1014_698a, 6); if(jnzd(0x1014_68fd, -0x93)) goto l_0x1014_68fd; /* jnz 0x101468fd */
            ii(0x1014_6990, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6993, 4); cmp(memd_a32[ds, eax + 0x1c], -0x1 /* 0xff */); /* cmp dword [eax+0x1c], 0xffffffff */
            ii(0x1014_6997, 2); if(jzd(0x1014_699f, 0x6)) goto l_0x1014_699f; /* jz 0x1014699f */
            ii(0x1014_6999, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1014_699d, 2); jmpd(0x1014_69a3, 0x4); goto l_0x1014_69a3; /* jmp 0x101469a3 */
        l_0x1014_699f:
            ii(0x1014_699f, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1014_69a3:
            ii(0x1014_69a3, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1014_69a6, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1014_69a9, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1014_69ac, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_69ae, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_69af, 1); popd(edi);                              /* pop edi */
            ii(0x1014_69b0, 1); popd(esi);                              /* pop esi */
            ii(0x1014_69b1, 1); popd(edx);                              /* pop edx */
            ii(0x1014_69b2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_69b3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_69b4, 1); retd(); return;                         /* ret */
        }
    }
}
